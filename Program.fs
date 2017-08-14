namespace NancyCore.Web
    module Main =
    open System
    open System.IO
    open Nancy
    open Microsoft.AspNetCore.Hosting
    open NancyCore.Web.Config


    [<EntryPoint>]
    let main argv =
        let host = 
            WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build()

        host.Run()
        0