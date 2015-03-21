# Introduction #
LSLSnippetsApp comes with three LSLSnippet XML Files (and you can create more from your re-usable LSL code or download shared XML):

|[llPlaySound.xml](http://lslsnippets.googlecode.com/files/llPlaySound.xml)|Inserts a custom code in the beginning of the script. The custom method called PlaySound.  Inserts one line of code in touch\_start code block. This line calls PlaySound.|
|:-------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|[llsay.xml](http://lslsnippets.googlecode.com/files/llsay.xml)|Inserts one llSay line of code in state\_entry.  Inserts one llSay line of code in touch\_start.|
|[NotecardReaderv3.xml](http://lslsnippets.googlecode.com/files/NotecardReaderv3.xml)|This xml does a lot. This is re-usable script that inspired this project. After using this xml, your script can read notecards. This script does not read comment lines found in the notecard. It also reads comma-separated lines.|

These are example files you may use out-of-the-box and are also found in the [Downloads](http://code.google.com/p/lslsnippets/downloads/list) area.

### How To Use a LSLSnippet XML File ###
  1. First, open a template script. File > Open
|![http://joeswammi.com/sl/se/lslsnippets/open.jpg](http://joeswammi.com/sl/se/lslsnippets/open.jpg)|>|![http://joeswammi.com/sl/se/lslsnippets/newlsl_scrn.jpg](http://joeswammi.com/sl/se/lslsnippets/newlsl_scrn.jpg)|
|:--------------------------------------------------------------------------------------------------|:|:----------------------------------------------------------------------------------------------------------------|

  1. Now, let's open the XML Creator tabpage. Snippets > Create XML
|![http://joeswammi.com/sl/se/lslsnippets/createxml_new.jpg](http://joeswammi.com/sl/se/lslsnippets/createxml_new.jpg)|
|:--------------------------------------------------------------------------------------------------------------------|

  1. Type in a Title in the title textbox and press 'Set Title>' button
  1. Choose an existing LSL Event method to insert this value into the InsertToEvent value from the dropdownlist.
|![http://joeswammi.com/sl/se/lslsnippets/dropdownlist.jpg](http://joeswammi.com/sl/se/lslsnippets/dropdownlist.jpg)|
|:------------------------------------------------------------------------------------------------------------------|

  1. Let's add our reusable code to the Code textbox.
```
llSay(0, "Hello World from XMLSnippets!!!");
```
|![http://joeswammi.com/sl/se/lslsnippets/codetextbox.jpg](http://joeswammi.com/sl/se/lslsnippets/codetextbox.jpg)|
|:----------------------------------------------------------------------------------------------------------------|

  1. Then click the 'Add' button to add the LSLSnippet xml block.
|![http://joeswammi.com/sl/se/lslsnippets/llsayblock.jpg](http://joeswammi.com/sl/se/lslsnippets/llsayblock.jpg)|
|:--------------------------------------------------------------------------------------------------------------|

  1. Click the 'Save XML As...' button. Then type in the File name 'helloworld' to save it in the snippets folder as 'helloworld.xml'
  1. Now it is time to use this 'helloworld.xml'. Click the previously opened new.lsl tab.
  1. From the Menu toolbar, click Snippets > Insert.
  1. Choose 'helloworld.xml' from the available LSLSnippets.
|![http://joeswammi.com/sl/se/lslsnippets/availsnips.jpg](http://joeswammi.com/sl/se/lslsnippets/availsnips.jpg)|
|:--------------------------------------------------------------------------------------------------------------|

  1. The entire script is now highlighted and read to be copied to the clipboard. You can press the 'Copy' or 'Select All' buttons for this step also.

  1. Save the new script or paste it into SL!
|![http://joeswammi.com/sl/se/lslsnippets/scriptinsl.jpg](http://joeswammi.com/sl/se/lslsnippets/scriptinsl.jpg)|
|:--------------------------------------------------------------------------------------------------------------|