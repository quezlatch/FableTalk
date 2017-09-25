#Fable Talk Notes

## Up and running
* dotnet new -i Fable.Template.Elmish.React
* dotnet new fable-elmish-react -n FableTalk
* cd FableTalk
* npm install
* dotnet restore
* quick look at the readme
* cd src
* dotnet fable npm-start
* test it

## Our stuff
* Strip out existing example code
* Add in our bits

## Fulma
* Paket: Add nuget package to current project (make sure you're on project!)
* if that doesn't work: mono .paket/paket.exe add Fulma --project src/FableTalk.fsproj 
* might need to reload window
* and might need to restart watcher