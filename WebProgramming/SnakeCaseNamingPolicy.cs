using System.Text;
using System.Text.Json;

namespace WebProgramming
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            var sb = new StringBuilder();
            sb.Append(char.ToLower(name[0]));
            for (int i = 1; i < name.Length; i++)
            {
                var c = name[i];
                if (char.IsUpper(c))
                {
                    sb.Append('_');
                    sb.Append(char.ToLower(c));
                }
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
