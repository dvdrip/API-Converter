# DatasetConverterAPI

### Instructions to build and run the API via debugging
1. Copy the https link of the repository `https://github.com/dvdrip/BARREDO_20240104.git`
2. Open Visual Studio and clone the repository using the link to create a local solution.
3. Build and run the solution using the shortcut key **F5**.
   - If you are on a machine with docker engine running, make sure to uncomment the `Docker` section inside `launchSettings.json` before running the project.
   - In *Solution Explorer*, click the *Show All Files* icon and navigate to the root of the project and include the **Dockerfile**

### Instructions to test the API via debugging
1. Navigate to Swagger UI using default port `3005`
2. The default url should be `https://localhost:3005/swagger`
3. A Report controller endpoint with route `/api/Report` should be available with a JSON structure for testing.
4. Click *Try it out* to see the input field, and *execute* to call the endpoint.

### Instructions to test using the included NUnit test project
2. Run the included test project using the shortcut keys `CTRL + R, A`
