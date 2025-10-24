using KH2AiTutorWeb.Usecases;

namespace KH2AiTutorWeb.Helpers
{
    public static class AddExtension
    {
        public static IServiceCollection AddKH2AiTutorClient(this IServiceCollection services)
        {
            services.AddSingleton<QueryTrapsUsecase>();
            //NextService: services.AddSingleton<$ClassName$>();

            {
                var groups = new List<HrefAndDisplayGroup>();
                groups.Add(new HrefAndDisplayGroup(
                    "push and pop",
                    [
                        new HrefAndDisplay("i/drop", "drop"),
                        new HrefAndDisplay("i/dup", "dup"),
                        new HrefAndDisplay("i/pop.bd", "pop.bd"),
                        new HrefAndDisplay("i/pop.sp", "pop.sp"),
                        new HrefAndDisplay("i/pop.sp.d", "pop.sp.d"),
                        new HrefAndDisplay("i/pop.wp", "pop.wp"),
                        new HrefAndDisplay("i/push", "push"),
                        new HrefAndDisplay("i/push.bd", "push.bd"),
                        new HrefAndDisplay("i/push.d.bd", "push.d.bd"),
                        new HrefAndDisplay("i/push.d.pop", "push.d.pop"),
                        new HrefAndDisplay("i/push.d.sp", "push.d.sp"),
                        new HrefAndDisplay("i/push.d.sp.d", "push.d.sp.d"),
                        new HrefAndDisplay("i/push.d.wp", "push.d.wp"),
                        new HrefAndDisplay("i/push.s", "push.s"),
                        new HrefAndDisplay("i/push.sp", "push.sp"),
                        new HrefAndDisplay("i/push.sp.d", "push.sp.d"),
                        new HrefAndDisplay("i/push.wp", "push.wp"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "int math",
                    [
                        new HrefAndDisplay("i/abs", "abs"),
                        new HrefAndDisplay("i/add", "add"),
                        new HrefAndDisplay("i/and", "and"),
                        new HrefAndDisplay("i/cvt.w.s", "cvt.w.s"),
                        new HrefAndDisplay("i/div", "div"),
                        new HrefAndDisplay("i/land", "land"),
                        new HrefAndDisplay("i/lor", "lor"),
                        new HrefAndDisplay("i/mod", "mod"),
                        new HrefAndDisplay("i/mul", "mul"),
                        new HrefAndDisplay("i/neg", "neg"),
                        new HrefAndDisplay("i/not", "not"),
                        new HrefAndDisplay("i/or", "or"),
                        new HrefAndDisplay("i/sll", "sll"),
                        new HrefAndDisplay("i/sra", "sra"),
                        new HrefAndDisplay("i/sub", "sub"),
                        new HrefAndDisplay("i/xor", "xor"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "float math",
                    [
                        new HrefAndDisplay("i/abs.s", "abs.s"),
                        new HrefAndDisplay("i/add.s", "add.s"),
                        new HrefAndDisplay("i/cos", "cos"),
                        new HrefAndDisplay("i/cvt.s.w", "cvt.s.w"),
                        new HrefAndDisplay("i/degr", "degr"),
                        new HrefAndDisplay("i/div.s", "div.s"),
                        new HrefAndDisplay("i/mod.s", "mod.s"),
                        new HrefAndDisplay("i/mul.s", "mul.s"),
                        new HrefAndDisplay("i/neg.s", "neg.s"),
                        new HrefAndDisplay("i/radd", "radd"),
                        new HrefAndDisplay("i/sin", "sin"),
                        new HrefAndDisplay("i/sub.s", "sub.s"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "int compare",
                    [
                        new HrefAndDisplay("i/seqz", "seqz"),
                        new HrefAndDisplay("i/sgez", "sgez"),
                        new HrefAndDisplay("i/sgtz", "sgtz"),
                        new HrefAndDisplay("i/slez", "slez"),
                        new HrefAndDisplay("i/sltz", "sltz"),
                        new HrefAndDisplay("i/snez", "snez"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "float compare",
                    [
                        new HrefAndDisplay("i/seqz.s", "seqz.s"),
                        new HrefAndDisplay("i/sgez.s", "sgez.s"),
                        new HrefAndDisplay("i/sgtz.s", "sgtz.s"),
                        new HrefAndDisplay("i/slez.s", "slez.s"),
                        new HrefAndDisplay("i/sltz.s", "sltz.s"),
                        new HrefAndDisplay("i/snez.s", "snez.s"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "branch / control",
                    [
                        new HrefAndDisplay("i/b", "b"),
                        new HrefAndDisplay("i/beqz", "beqz"),
                        new HrefAndDisplay("i/bnez", "bnez"),
                        new HrefAndDisplay("i/exit", "exit"),
                        new HrefAndDisplay("i/halt", "halt"),
                        new HrefAndDisplay("i/jal", "jal"),
                        new HrefAndDisplay("i/ret", "ret"),
                        new HrefAndDisplay("i/syscall", "syscall"),
                        new HrefAndDisplay("traps", "(known traps)"),
                    ]
                ));
                groups.Add(new HrefAndDisplayGroup(
                    "memcpy",
                    [
                        new HrefAndDisplay("i/memcpy", "memcpy"),
                        new HrefAndDisplay("i/memcpy.bd", "memcpy.bd"),
                        new HrefAndDisplay("i/memcpy.sp", "memcpy.sp"),
                        new HrefAndDisplay("i/memcpy.sp.d", "memcpy.sp.d"),
                        new HrefAndDisplay("i/memcpy.wp", "memcpy.wp"),
                    ]
                ));

                services.AddSingleton(groups.AsEnumerable());
            }
            return services;
        }
    }
}