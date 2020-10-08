# demoXunitVSCode
Sample .NET core project with Xunit in VSCode

1. Clone the Repository
2. Open in VS Code
3. Move to DemoMath folder and run below commands
    a. dotnet restore
    b. dotnet build
    c. move back to parent folder(DemoXunitVsCode)
4. Move to DemoMath.Test folder and run below commands
    a. dotnet restore
    b. dotnet build
5. Install '.Net Core Test Explorer' extention in VS Code
6. Goto VS Code Settings -> Extensions -> .Net Core Test Explorer -> Test Project Path -> '*Test*'
7. Goto test tab in Vs Code (usually on left command tab)
8. You will see .NET Test explorer with all the test cases listed which has names that contain 'Test'
9. You can run individual tests or all the tests listed with a 'play' button