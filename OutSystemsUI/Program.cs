using Microsoft.Extensions.Hosting;
using OutSystems.Application.Initialization.ASPNetCore;

namespace ssOutSystemsUI {
    public class Program : ProgramBase<Startup> {
        public static void Main(string[] args) {
            RealMain(args);
        }
    }
}
