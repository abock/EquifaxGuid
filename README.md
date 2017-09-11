# Equifax GUID

[![Build status](https://ci.appveyor.com/api/projects/status/9s5bbjr35hanmws6?svg=true)](https://ci.appveyor.com/project/abock/equifaxguid)

An open source implementation for Equifax-style unique identifiers
(`MMDDyyHHmm`) for .NET Standard 2.0. Available on
[nuget.org](https://www.nuget.org/packages/EquifaxGuid/).

Use `Equifax.Guid.NewGuid()` to generate a `System.Guid` with an
[Equifax-level of uniquenes](https://nakedsecurity.sophos.com/2017/09/10/equifax-woeful-pins-put-frozen-credit-files-at-risk/)
for best security.

```csharp
csharp> Equifax.Guid.NewGuid()
00000000-0000-0000-0000-000910171941
```

It is also available as an [HTTP API](https://equifaxguid.azurewebsites.net/api/EquifaxGuid)
(an Azure Function) that will return 10 Equifax GUIDs at a time in `text/plain`, one GUID per line:

```bash
💩 curl https://equifaxguid.azurewebsites.net/api/EquifaxGuid
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
00000000-0000-0000-0000-000910171941
```

![Chief Security Expert](dog.jpg)

_Chief Security Expert, Dog_

Project sponsored by [@abock](https://twitter.com/abock)'s
[CatOverflow.com](http://catoverflow.com) and
[DogOverflow.com](http://dogoverflow.com).