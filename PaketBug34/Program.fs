open Akka.Cluster.Discovery
open Akkling

[<EntryPoint>]
let main _ = 
    let system = System.create "test" (Configuration.load())
    ClusterDiscovery.Join system |> ignore
    system.WhenTerminated.Wait()
    0
