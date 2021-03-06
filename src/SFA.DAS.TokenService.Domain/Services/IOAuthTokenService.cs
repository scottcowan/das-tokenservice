﻿using System.Threading.Tasks;

namespace SFA.DAS.TokenService.Domain.Services
{
    public interface IOAuthTokenService
    {
        Task<OAuthAccessToken> GetAccessToken(string clientSecret);
        Task<OAuthAccessToken> GetAccessTokenFromRefreshToken(string clientSecret, string refreshToken);
    }
}