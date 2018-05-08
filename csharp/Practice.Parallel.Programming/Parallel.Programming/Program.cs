using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    struct Email
    {
        string name;
        string address;
    };

    public class Program
    {
        static void Main(string[] args)
        {
            List<Email> emails = new List<Email>();
            string DbConnection = "";

            var parallelLoopResult = Parallel.ForEach
            (
                source: emails,
                parallelOptions: new ParallelOptions { MaxDegreeOfParallelism = 2 },
                localInit: () => new
                {
                    DbConnection
                },
                body: (email, concat, local) =>
                {
                    // process the email
                    // use the local.Connection
                    return local; // pass the connection to the next loop
                },
                localFinally: local =>
                {
                    DbConnection = "Dispose DB connection";
                }
            );
        }
    }
}
