namespace NancyCore.Web
    module Main =
        open System.IO
        open Microsoft.AspNetCore.Hosting
        open Microsoft.Extensions.Hosting
        open Microsoft.Extensions.Logging
        open NancyCore.Web.Config


        [<EntryPoint>]
        let main argv =
            let host = 
                Host
                    .CreateDefaultBuilder(argv)
                    .ConfigureWebHostDefaults(fun wb -> 
                        wb
                            .UseKestrel(fun k -> 
                                k.AllowSynchronousIO <- true
                            )
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseStartup<Startup>()
                            .ConfigureLogging(fun _ lg -> 
                                lg
                                    .AddDebug()
                                    .AddConsole() |> ignore
                            ) |> ignore
                        ()
                    )
                    .Build()
            host.Run()
            0