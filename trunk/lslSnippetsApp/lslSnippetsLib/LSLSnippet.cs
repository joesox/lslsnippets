// lslSnippetsLib v1.1.0
// by Seneca Taliaferro/Joseph P. Socoloski III (Minoa)
// Copyright 2008. All Rights Reserved.
// http://lslsnippets.googlecode.com
// NOTE:   Add your own LSL snippets to an existing script.
// WHAT'S NEW: 	
//          - Bug Fix issue #1: Added state_entry to GetEventMethod
// LIMITS:  
// TODO:    
//LICENSE
//BY DOWNLOADING AND USING, YOU AGREE TO THE FOLLOWING TERMS:
//If it is your intent to use this software for non-commercial purposes, 
//such as in academic research, this software is free and is covered under 
//the GNU GPL License, given here: <http://www.gnu.org/licenses/gpl.txt> 
////////////////////////////////////////////////////////////////////////////

using System;
using System.Text;
using Joe.Utils;
using System.Xml;

namespace lslSnippetsLib
{
    public class LSLSnippet
    {
        public XmlDocument xmlDoc = new XmlDocument();

        /// <summary>
        /// The complete LSL Script.
        /// </summary>
        public string LSLScript
        {
            get { return _LSLScript; }
            set { _LSLScript = value; }
        }
        string _LSLScript = "";

        public LSLSnippet(string lslscript)
        {
            LSLScript = lslscript; 
        }

        /// <summary>
        /// Count each '{' starting bracket starting from start_pos.
        /// Useful to find the end of a codeblock by counting '}' back out.
        /// </summary>
        /// <param name="src">String to search</param>
        /// <param name="start_pos">Where you wish to start the search.</param>
        /// <returns>Number of starting '{' brackets.</returns>
        int CountStartBrackets(string src, int start_pos)
        {
            int numOfBrackets = 0;
            int endOfdefaultpos = start_pos;
            while (src.IndexOf("{", endOfdefaultpos + 1) != -1)
            {
                numOfBrackets = numOfBrackets + 1;
                endOfdefaultpos = src.IndexOf("{", endOfdefaultpos + 1);

            }

            return numOfBrackets;
        }

        /// <summary>
        /// Insert this snippet into the current lslscript.
        /// All inserts are completed in the 'default' State of lsl script.
        /// </summary>
        /// <param name="newlslscript">the new lslscript.</param>
        /// <returns>true, if completed.</returns>
        public bool DoInsert(out string newlslscript)
        {
            bool completed = false;

            try
            {
                string curstr = LSLScript;

                //Create the steps
                //Get all Snippet blocks.
                XmlNodeList elemList = xmlDoc.GetElementsByTagName("Snippet");
                string[] InsertToEvents = new string[elemList.Count];
                string[] InsertTexts = new string[elemList.Count];
                for (int i = 0; i < elemList.Count; i++)
                {
                    //Get the snippet commands from the XML...
                    InsertToEvents[i] = elemList[i].Attributes["InsertToEvent"].Value;//InsertToEvent = "state_entry"
                    //
                    InsertTexts[i]= elemList[i].InnerText;
                }

                //Find the 'default' State
                int default_startpos = 0;
                int state_entry_startpos = 0;

                //Get the pos of default State
                default_startpos = curstr.IndexOf("default");

                //Do All of the inserts
                for (int i = 0; i < InsertTexts.Length; i++)
                {
                    if (default_startpos != -1)
                    {
                        //Look for the first Event to Insert...
                        state_entry_startpos = curstr.IndexOf(InsertToEvents[i] + "(");

                        //If found Event block...
                        if (state_entry_startpos != -1)
                        {
                            //Look for the next "{", then insert
                            state_entry_startpos = curstr.IndexOf("{", state_entry_startpos) + 1;
                            curstr = curstr.Insert(state_entry_startpos, "\r\n\t\t" + InsertTexts[i] + "\r\n");
                        }
                        else
                        {
                            //Did not find Event block 
                            if (InsertToEvents[i].ToLower() == "lslstart")
                            {
                                curstr = curstr.Insert(0, InsertTexts[i] + "\r\n");
                            }
                            else if (InsertToEvents[i].ToLower() == "lslend")
                            {
                                curstr = curstr.Insert(curstr.Length, "\r\n" + InsertTexts[i] + "\r\n");
                            }
                            else
                            {
                                //OR add it after 'state_entry' (which should be there)
                                default_startpos = curstr.IndexOf("state_entry");

                                int startbrackets = CountStartBrackets(curstr, default_startpos);
                                state_entry_startpos = default_startpos;
                                for (int x = 0; x < startbrackets; x++)
                                {
                                    //We want to start at the correct spot so...
                                    state_entry_startpos = curstr.IndexOf("}", state_entry_startpos) + 1;
                                }

                                //Is this a new custom method??
                                if (InsertToEvents[i].ToLower() == "new")
                                {
                                    //Find end of state_entry 

                                    //complete insert
                                    curstr = curstr.Insert(state_entry_startpos, "\r\n\t\t" + InsertTexts[i] + "\r\n");
                                }
                                else
                                {
                                    //Look to insert a know event method
                                    curstr = curstr.Insert(state_entry_startpos, GetEventMethod(InsertToEvents[i]));

                                    //Now back to business...
                                    state_entry_startpos = curstr.IndexOf(InsertToEvents[i] + "(");
                                    state_entry_startpos = curstr.IndexOf("{", state_entry_startpos) + 1;
                                    curstr = curstr.Insert(state_entry_startpos, "\r\n\t\t" + InsertTexts[i] + "\r\n");
                                }
                            }
                        }
                    }
                    else
                    {
                        //Did not find default block in script
                        newlslscript = "Did not find default block in script.";
                    }
                }
                
                completed = true;
                newlslscript = curstr;
            }
            catch (Exception)
            {
                newlslscript = "";
                completed = false;
            }

            return completed;
        }

        /// <summary>
        /// Return the Method's event line and empty block according to lslWiki.
        /// Supports: at_rot_target(integer tnum, rotation targetrot, rotation ourrot),
        /// at_target(integer tnum, vector targetpos, vector ourpos),
        /// attach(key id),
        /// changed(integer change),
        /// collision(integer num_detected),
        /// collision_end(integer num_detected),
        /// collision_start(integer num_detected),
        /// control(key id, integer held, integer change),
        /// dataserver(key queryid, string data),
        /// email(string time, string address, string subj, string message, integer num_left),
        /// http_response(key request_id, integer status, list metadata, string body),
        /// land_collision(vector pos),
        /// land_collision_end(vector pos),
        /// land_collision_start(vector pos),
        /// link_message(integer sender_num, integer num, string str, key id),
        /// listen(integer channel, string name, key id, string message),
        /// money(key id, integer amount),
        /// moving_end(),
        /// moving_start(),
        /// no_sensor(),
        /// not_at_rot_target(),
        /// not_at_target(),
        /// object_rez(key id),
        /// on_rez(integer start_param),
        /// remote_data(integer event_type, key channel, key message_id, string sender, integer idata, string sdata),
        /// run_time_permissions(integer perm),
        /// sensor(integer num_detected),
        /// state_exit(),
        /// timer(),
        /// touch(integer num_detected),
        /// touch_start(integer total_number),
        /// touch_end(integer num_detected)
        /// </summary>
        /// <param name="eventname">http://rpgstats.com/wiki/index.php?title=Events</param>
        /// <returns>Empty LSL method event block string. eg. eventname='money', returns "money(key id, integer amount)\r\n\t{\r\n\t}\r\n"</returns>
        string GetEventMethod(string eventname)
        {
            string line = "";
            switch (eventname.ToLower())
            {
                case "at_rot_target":
                    line = "at_rot_target(integer tnum, rotation targetrot, rotation ourrot)\r\n\t{\r\n\t}\r\n";
                    break;
                case "at_target":
                    line = "at_target(integer tnum, vector targetpos, vector ourpos)\r\n\t{\r\n\t}\r\n";
                    break;
                case "attach":
                    line = "attach(key id)\r\n\t{\r\n\t}\r\n";
                    break;
                case "changed":
                    line = "changed(integer change)\r\n\t{\r\n\t}\r\n";
                    break;
                case "collision":
                    line = "collision(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                case "collision_end":
                    line = "collision_end(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                case "collision_start":
                    line = "collision_start(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                case "control":
                    line = "control(key id, integer held, integer change)\r\n\t{\r\n\t}\r\n";
                    break;
                case "dataserver":
                    line = "dataserver(key queryid, string data)\r\n\t{\r\n\t}\r\n";
                    break;
                case "email":
                    line = "email(string time, string address, string subj, string message, integer num_left)\r\n\t{\r\n\t}\r\n";
                    break;
                case "http_response":
                    line = "http_response(key request_id, integer status, list metadata, string body)\r\n\t{\r\n\t}\r\n";
                    break;
                case "land_collision":
                    line = "land_collision(vector pos)\r\n\t{\r\n\t}\r\n";
                    break;
                case "land_collision_end":
                    line = "land_collision_end(vector pos)\r\n\t{\r\n\t}\r\n";
                    break;
                case "land_collision_start":
                    line = "land_collision_start(vector pos)\r\n\t{\r\n\t}\r\n";
                    break;
                case "link_message":
                    line = "link_message(integer sender_num, integer num, string str, key id)\r\n\t{\r\n\t}\r\n";
                    break;
                case "listen":
                    line = "listen(integer channel, string name, key id, string message)\r\n\t{\r\n\t}\r\n";
                    break;
                case "money":
                    line = "money(key id, integer amount)\r\n\t{\r\n\t}\r\n";
                    break;
                case "moving_end":
                    line = "moving_end()\r\n\t{\r\n\t}\r\n";
                    break;
                case "moving_start":
                    line = "moving_start()\r\n\t{\r\n\t}\r\n";
                    break;
                case "no_sensor":
                    line = "no_sensor()\r\n\t{\r\n\t}\r\n";
                    break;
                case "not_at_rot_target":
                    line = "not_at_rot_target()\r\n\t{\r\n\t}\r\n";
                    break;
                case "not_at_target":
                    line = "not_at_target()\r\n\t{\r\n\t}\r\n";
                    break;
                case "object_rez":
                    line = "object_rez(key id)\r\n\t{\r\n\t}\r\n";
                    break;
                case "on_rez":
                    line = "on_rez(integer start_param)\r\n\t{\r\n\t}\r\n";
                    break;
                case "remote_data":
                    line = "remote_data(integer event_type, key channel, key message_id, string sender, integer idata, string sdata)\r\n\t{\r\n\t}\r\n";
                    break;
                case "run_time_permissions":
                    line = "run_time_permissions(integer perm)\r\n\t{\r\n\t}\r\n";
                    break;
                case "sensor":
                    line = "sensor(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                case "state_entry":
                    line = "state_entry()\r\n\t{\r\n\t}\r\n";
                    break;
                case "state_exit":
                    line = "state_exit()\r\n\t{\r\n\t}\r\n";
                    break;
                case "timer":
                    line = "timer()\r\n\t{\r\n\t}\r\n";
                    break;
                case "touch":
                    line = "touch(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                case "touch_start":
                    line = "touch_start(integer total_number)\r\n\t{\r\n\t}\r\n";
                    break;
                case "touch_end":
                    line = "touch_end(integer num_detected)\r\n\t{\r\n\t}\r\n";
                    break;
                default:
                    break;
            }
            return "\r\n\t" + line;
        }

        #region Common XML Snippet
        /// <summary>
        /// XML Snippet template.
        /// $title, $eventname, $code
        /// </summary>
        public static StringBuilder Getblankxml()
        {
            StringBuilder defaultxml = new StringBuilder();
            defaultxml.AppendLine("<LSLSnippets xmlns=\"http://joeswammi.com/sl/se/LSLSnippet\">");
            defaultxml.AppendLine("<CodeSnippet Format=\"1.0.0\" Title=\"$title\">");
            defaultxml.AppendLine("<Snippet InsertToEvent=\"$eventname\">");
            defaultxml.AppendLine("<![CDATA[$code]]>");
            defaultxml.AppendLine("</Snippet>");
            defaultxml.AppendLine("</CodeSnippet>");
            defaultxml.AppendLine("</LSLSnippets>");
            return defaultxml;
        }

        /// <summary>
        /// Searches the text given for "Title=\"" and its value.
        /// Use for string 'Replace'
        /// </summary>
        /// <param name="text"></param>
        /// <returns>"Title's value. eg. 'Title="llSayScript"' returns "llSayScript"</returns>
        public static string GetTitlevalue(string text)
        {
            string titlestr = "Title=\"";
            int start_pos = text.IndexOf(titlestr) + titlestr.Length;
            string temp = text.Substring(start_pos);
            int nextq_pos = temp.IndexOf("\"");
            titlestr = temp.Substring(0, nextq_pos);

            return titlestr;
        }

        /// <summary>
        /// Create a entire XML Snippet file.
        /// (Use AddSnippet() to add more snippets after creating this file)
        /// </summary>
        /// <param name="title">Title of XML Snippet file.</param>
        /// <param name="eventname">InsertToEvent value.</param>
        /// <param name="code">LSL code to place in LSL eventname.</param>
        /// <returns>StringBuilder of complete XML snippet file.</returns>
        public static StringBuilder CreateXMLSnippet(string title, string eventname, string code)
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<LSLSnippets xmlns=\"http://joeswammi.com/sl/se/LSLSnippet\">");
            xml.AppendLine("<CodeSnippet Format=\"1.0.0\" Title=\"" + title + "\">");
            xml.AppendLine("<Snippet InsertToEvent=\"" + eventname + "\">");
            xml.AppendLine("<![CDATA[" + code + "]]>");
            xml.AppendLine("</Snippet>");
            xml.AppendLine("</CodeSnippet>");
            xml.AppendLine("</LSLSnippets>");
            return xml;
        }

        /// <summary>
        /// Add a snippet to existing XML snippet file.
        /// </summary>
        /// <param name="xml">String of a properly formatted XML Snippet file.</param>
        /// <param name="eventname">InsertToEvent value.</param>
        /// <param name="code">LSL code to place in LSL eventname.</param>
        /// <returns>StringBuilder of complete XML snippet file.</returns>
        public static StringBuilder AddSnippet(string xml, string eventname, string code)
        {
            //Remove the template snippet, if there
            string blanksnip = "<Snippet InsertToEvent=\"$eventname\">\r\n<![CDATA[$code]]>\r\n</Snippet>\r\n";
            if (xml.Contains(blanksnip))
            {
                xml = xml.Replace(blanksnip, "");
            }

            //Create this new snippet...
            StringBuilder snippetxmlblock = new StringBuilder();
            snippetxmlblock.AppendLine("<Snippet InsertToEvent=\"" + eventname + "\">");
            snippetxmlblock.AppendLine("<![CDATA[" + code + "]]>");
            snippetxmlblock.AppendLine("</Snippet>");

            //Always insert the new snippet block 
            StringBuilder new_xml = new StringBuilder();
            new_xml.Append(xml);//add previous xml to new_xml
            //Now insert the block before ending tags
            new_xml.Insert(xml.LastIndexOf("</CodeSnippet>"), snippetxmlblock.ToString());

            return new_xml;
        }
        #endregion
    }
}
