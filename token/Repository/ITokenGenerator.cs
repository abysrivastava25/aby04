using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using token.Models.entityModels;

namespace token.Repository
{
    public interface ITokenGenerator
    {
        public string GenerateToken(UserModel user);
    }
}
