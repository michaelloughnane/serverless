{
  "generatedBy": "Microsoft.NET.Sdk.Functions-3.0.11",
  "configurationSource": "attributes",
  "bindings": [
    {
      "type": "httpTrigger",
      "methods": [
        "get",
        "post"
      ],
      "authLevel": "anonymous",
      "name": "req"
    }
  ],
  "disabled": false,
  "scriptFile": "../bin/Azure.dll",
  "entryPoint": "My.Functions.HttpTriggerCSharp1.Run"
}
