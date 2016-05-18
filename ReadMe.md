# .NET Core Class Library

## Reference a .NET Core class library from a .NET 4.6 App

1. Create a new .NET Core class library

2. Edit project.json to specify "netstandard1.3" under "frameworks"

    ```json
    {
      "version": "1.0.0-*",

      "dependencies": {
        "NETStandard.Library": "1.5.0-rc2-24027"
      },

      "frameworks": {
        "netstandard1.3": { }
      }
    }
    ```

3. Add a new .NET 4.6 Console App
  - Place it in the src directory

4. Add a project.json file to the console app
  - Add a runtimes section
  - Add the .NET Core class library as a dependency
  - Specify net46 for the framework

    ```json
    {
      "version": "1.0.0-*",

      "dependencies": {
        "NetCoreClassLibrary": "1.0.0"
      },
      "runtimes": {
        "win": { }
      },
      "frameworks": {
        "net46": { }
      }
    }
    ```
5. Build the ConsoleApp
  - A special NuGet reference should be added to References
  - Ignore errors generated during classic package restore:

    ```
    System.Runtime.Loader 4.0.0-rc2-24027 is not compatible with .NETFramework,Version=v4.6 (win).
    ```
  - Running the console app should succeed.