using AuthOrchestrator.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthOrchestrator.Jwt
{
    public interface IJwtService
    {
        public string GenerateJwtToken(IUserForToken user);
    }
}
