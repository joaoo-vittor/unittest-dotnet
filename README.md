<div align="center">
  <h2>Básico do xUnit - .NET</h2>
</div>

---

# ATENÇÃO

> Tenha atenção ao path dos arquivos no seu projeto podem estar direfentes desse projeto

# Rodar os testes

```
dotnet test **/*Tests.csproj --logger "console;verbosity=detailed"
```

# Gerar .xml para o `Code Coverage`

```
dotnet test **/*Tests.csproj --verbosity minimal --collect:"XPlat Code Coverage"
```

OU

```
dotnet test **/*Tests.csproj --verbosity detailed --collect:"XPlat Code Coverage"
```

# Informar Arquivo de configuração para o `Code Coverage`

```
dotnet test **/*Tests.csproj --verbosity detailed --collect:"XPlat Code Coverage" --settings **/runsettings.xml
```


# Instalar o `ReportGenerator`

> Feramenta para gerar uma interface amigavel para visualização do `Code Coverage`

```
dotnet tool install --global dotnet-reportgenerator-globaltool
```

# Gerar Site estatico com relárorio de `Code Coverage`

```
reportgenerator "-reports:**/TestResults/**/coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html
```



