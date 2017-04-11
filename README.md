# StronglyTypedSettings
----------

Why are settings always Key-Value-Pairs of strings?

Bet you never thought about it, but its such a pain to try to create hierarchical settings in your config file or you have to serialize an object as a string and store that in a database.

This item template is a simple T4 template that will read an XML file with keys that are period-separated and create a hierachical object structure from it.

So, for example:

if we have the following XML values, 

```xml
<Settings>

  <Entry name="Global.Login.Username" description="Defines the global username for determining how to get in" type="string">eddie</Entry>

  <Entry name="Global.Login.Password" description="Defines the global password for determining how to get in" type="string">eddie</Entry>

  <Entry name="Global.Login.Domain" description="Defines the global Domain for determining how to get in" type="string">eddie</Entry>

  <Entry name="Global.Login.Retries" description="Defines the global number of allowed retries" type="int">3</Entry>

  <Entry name="Global.Login.FallBack" description="Defines the global username for determining how to get in" type="string">eddie</Entry>

  <Entry name="Global.ShouldSave" description="Defines whether to save or not" type="bool">true</Entry>

</Settings>
```


You would get a generated object that looks like this:

```csharp
int x = settings.Global.Login.Retries;
bool y= settings.Global.ShouldSave;
``` 
You can set them by simply assigning a value to it:

```csharp
settings.Global.ShouldSave = true;
settings.Global.Login.Retries = 3;
```
