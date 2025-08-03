using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiTrade.Core.DTOs
{
    public record RegistationResponse
    (
        string UserName,
        string Name,
        string Email,
        bool Status,
        string ReturnMessage
    );
}
