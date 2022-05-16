### Description
This is a fairly simple libary that converts any XML file into HTML format so it can be displayed in a browser.

For Example, the following file
```xml
<My>
    <Awesome>XML</Awesome>
    <File />
</My>
```
Would be displayed as
<details>
    <summary>My</summary>
    <ul>
        <li>
            <details>
                <summary>Awesome</summary>
                <ul>
                    XML
                </ul>
            </details>
        </li>
        <li>
            <details>
                <summary>File</summary>
                <ul>
                </ul>
            </details>
        </li>
    </ul>
</details>

### Usage
There are multiple options to call the Function. Both XDocuments and strings can be converted.
Also you can optionally provide any writable Stream object to integrate the HTML generation into your own rendering pipeline without passing around strings.

You can optionally create an **XmlToHtmlSerializationSettings** instance and pass it to the function.
This settings class contains a few useful options for serialization and HTML generation to customize the generated code.