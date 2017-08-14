namespace NancyCore.Web.Config

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Nancy.Owin

type Startup() =
    member this.Configure(app: IApplicationBuilder) =
        app.UseOwin(fun x -> x.UseNancy() |> ignore ) |> ignore