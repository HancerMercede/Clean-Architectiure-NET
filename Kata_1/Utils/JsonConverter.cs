using Kata_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kata_1.Utils
{
    public static class JsonConverter
    {
        public static string ToJson(User user)
        {
            var json = JsonSerializer.Serialize(user);

            return json;
        }
    }
}
