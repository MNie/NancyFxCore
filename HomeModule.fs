namespace NancyCore.Web.Modules
open Nancy

type HomeModule() as this =
    inherit NancyModule()
    do
        this.Get("/", fun param -> "Hello World!" :> obj)
