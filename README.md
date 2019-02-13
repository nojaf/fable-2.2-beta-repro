# Fable 2.2 beta repro

1. Start webpack-dev-server
2. Should compile alright first time
3. Uncomment // Rise in Type.fs -> will throw error in State.fs (due to <WarningsAsErrors>25</WarningsAsErrors>)
4. Comment Rise in Type.fs -> code should compile again, yet it doesnt
5. Fable.React error still remains

