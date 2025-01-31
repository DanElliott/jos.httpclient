﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace JOSHttpClient.Common
{
    public interface IGitHubClient
    {
        Task<IReadOnlyCollection<GitHubRepositoryDto>> GetRepositories();
    }
}
