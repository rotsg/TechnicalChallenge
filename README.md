# TechnicalChallenge

_ASP.NET Web API_

### NuGet packages 📋

```
PM> Install-Package Csv -Version 2.0.62
```

## GET api/HelloWorld

### Request Information

_URI Parameters: None_

_Body Parameters: None_

### Response Information

_Resource Description: string_

### Response Formats

_application/json, text/json_

```
"sample string 1"
```

_application/xml, text/xml_

```
<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">sample string 1</string>
```
## GET api/Values

### Request Information

_URI Parameters: None_

_Body Parameters: None_

### Response Information

_Resource Description: Collection of Data_

| Name | Description | Type | Additional information |
| ------------- | ------------- | ------------- | ------------- |
| SerialNumber  |   |  String |  None |
| Enterprise  |   |  String |  None |
| Solicitude  |   |  String |  None |
| User  |   |  String |  None |
| Km  |   |  String |  None |
| Price  |   |  String |  None |

### Response Formats

_application/json, text/json_

```
[
  {
    "SerialNumber": "sample string 1",
    "Enterprise": "sample string 2",
    "Solicitude": "sample string 3",
    "User": "sample string 4",
    "Km": "sample string 5",
    "Price": "sample string 6"
  },
  {
    "SerialNumber": "sample string 1",
    "Enterprise": "sample string 2",
    "Solicitude": "sample string 3",
    "User": "sample string 4",
    "Km": "sample string 5",
    "Price": "sample string 6"
  }
]
```

_application/xml, text/xml_

```
<ArrayOfData xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/TechnicalChallenge.Models">
  <Data>
    <Enterprise>sample string 2</Enterprise>
    <Km>sample string 5</Km>
    <Price>sample string 6</Price>
    <SerialNumber>sample string 1</SerialNumber>
    <Solicitude>sample string 3</Solicitude>
    <User>sample string 4</User>
  </Data>
  <Data>
    <Enterprise>sample string 2</Enterprise>
    <Km>sample string 5</Km>
    <Price>sample string 6</Price>
    <SerialNumber>sample string 1</SerialNumber>
    <Solicitude>sample string 3</Solicitude>
    <User>sample string 4</User>
  </Data>
</ArrayOfData>
```
