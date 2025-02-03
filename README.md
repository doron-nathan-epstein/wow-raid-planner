# wow-raid-planner

``` mermaid
graph TD;
    subgraph WoW Raid Planner
        A[Client UI] --> B[API]
        B --> C[(Database)]
    end

    A -- Authentication --> D[Discord] 
    B <-- Queries/Events -->  D
    
```
