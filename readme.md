# Episerver Editor alt text problem example
[Link to Episerver World](https://world.episerver.com/forum/developer-forum/-Episerver-75-CMS/Thread-Container/2020/6/image-alt-text-when-dragging-and-dropping-an-image-into-tinymce/)

HTML Rendered:
```HTML
    <p>Image added via "Insert &gt; Image" menu, Alt text comes from this dialog.</p>
    <p>
        <img src="/globalassets/logotype.png" border="0" alt="Alt Text from insert dialogue" />
    </p>
    <hr />
    <p>Image added by dragging from media tab. Alt text is auto populated from the name property.</p>
    <p>
        <img src="/globalassets/logotype.png" border="0" alt="logotype.png" />
    </p>
```
