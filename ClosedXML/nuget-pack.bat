nuget pack .\ClosedXML.csproj -Prop Configuration=Release -OutputDirectory .\
nuget push *.nupkg -Source GitHub
