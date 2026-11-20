using OpenKh.Kh2Bdx.Utils;

namespace KH2AiTutorWeb.Usecases
{
    public class CCompileUsecase
    {
        public record Result(string Bdscript);

        public Result Compile(string c, TextWriter output, bool toBdscript)
        {
            var result = new BdxCEncoder()
                .EncodeC(
                    c,
                    "noname.c",
                    output,
                    output
                );

            if (toBdscript)
            {
                var fullBdscript = BdxCScript.AddHeader(
                    result,
                    "noname.c"
                );

                return new Result(fullBdscript);
            }
            else
            {
                return new Result(result.Bdscript + Environment.NewLine);
            }
        }
    }
}
