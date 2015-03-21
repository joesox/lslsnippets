# Introduction to Understanding LSLSnippet XML #

# Three Basic Values and Tags #
  * Title (A summary name of the LSLSnippet. One value per XML file.)
  * InsertToEvent (LSL event method that you want to place associated code. eg. 'state\_entry')
  * <![CDATA[.md](.md)]> (The code that you want to place in the previously associated InsertToEvent)

## Example LSL Snippet XML File ##
```
<LSLSnippets xmlns="http://joeswammi.com/sl/se/LSLSnippet">
  <CodeSnippet Format="1.0.0" Title="llPlaySound">
    <Snippet InsertToEvent="touch_start">
      <![CDATA[PlaySound("my_soundwav", 1);]]>
    </Snippet>
    <Snippet InsertToEvent="lslstart">
      <![CDATA[PlaySound(string sound, float volume)
{
	if(llGetInventoryType(sound) == INVENTORY_SOUND)
		llPlaySound(sound, volume);
}]]>
    </Snippet>
  </CodeSnippet>
</LSLSnippets>
```

## Currently Supported LSL Methods (valid InsertToEvent values) ##
  * at\_rot\_target
  * at\_target
  * attach
  * changed
  * collision
  * collision\_end
  * collision\_start
  * control
  * dataserver
  * email
  * http\_response
  * land\_collision
  * land\_collision\_end
  * land\_collision\_start
  * link\_message
  * listen
  * _lslstart_ [this as the InsertToEvent value to insert code at the start of a lsl script](Use.md)
  * _lslend_ [this as the InsertToEvent value to insert code at the end of a lsl script](Use.md)
  * money
  * moving\_end
  * moving\_start
  * no\_sensor
  * not\_at\_rot\_target
  * not\_at\_target
  * object\_rez
  * on\_rez
  * remote\_data
  * run\_time\_permissions
  * sensor
  * state\_entry
  * state\_exit
  * timer
  * touch
  * touch\_start
  * touch\_end