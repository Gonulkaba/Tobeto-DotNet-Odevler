﻿using AutoMapper;
using Core.Utilities.Hashing;
using DataAccess.Abstracts;
using Entities;
using MediatR;

namespace Business.Features.Auth.Commands.Register
{
    public class RegisterCommand: IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;

            public RegisterCommandHandler(IMapper mapper, IUserRepository userRepository)
            {
                _mapper = mapper;
                _userRepository = userRepository;
            }

            public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                // Register komutu trigger olduğunda çalışacak fonk.

                User user = _mapper.Map<User>(request);

                byte[] passwordHash, passwordSalt;

                HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

                user.PasswordSalt = passwordSalt;
                user.PasswordHash = passwordHash;

                await _userRepository.AddAsync(user);
            }
        }
    }
}
