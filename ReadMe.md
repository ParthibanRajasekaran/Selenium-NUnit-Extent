# Selenium NUnit Extent

This template uses C# to implement Selenium with NUnit framework, Fluent Page Object Model(FPOM) design pattern and Extent reporting.

## Pre-requisite
.NET 7.0
IDE 

## Get Started
- Clone the project
```git clone https://github.com/ParthibanRajasekaran/Selenium-NUnit-Extent.git```
- Checkout 'main' branch

## To run the automation tests via cli

### To run the 'smoke' tests in Firefox 
dotnet test Selenium-Nunit-Extent.csproj --filter TestCategory=smoke -- TestRunParameters.Parameter\(name=\"browserName\",value=\"firefox\"\)

### To run the 'smoke' tests in Chrome 
dotnet test Selenium-Nunit-Extent.csproj --filter TestCategory=smoke -- TestRunParameters.Parameter\(name=\"browserName\",value=\"chrome\"\)

### To run all the tests in Chrome 
dotnet test Selenium-Nunit-Extent.csproj -- TestRunParameters.Parameter\(name=\"browserName\",value=\"chrome\"\)

### To run all the tests in the browser set via App.config
dotnet test Selenium-Nunit-Extent.csproj


## Priority of browser (Selenium-Nunit-Extent/utils/BaseTest => SetupBrowser())
1. Cli
2. App.config
3. Chrome