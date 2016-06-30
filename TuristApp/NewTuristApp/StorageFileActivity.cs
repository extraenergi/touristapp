using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NewTuristApp
{
    class StorageFileActivity : MainActivity
    {
        [Java.Interop.Export("WriteFile")]
        public void WriteFile(ToggleButton toggle)
        {
            try
            {
                if (toggle.Id == Resource.Id.TextSettingToggle)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Text på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Text av";
                    }
                    var textFileName = "TextText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + textFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleOnline)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Online";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Offline";
                    }
                    var onlineFileName = "onlineText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + onlineFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleButtonResturant)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Resturanger på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Resturanger av";
                    }
                    var resturantFileName = "ResturantText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + resturantFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleButtonSubway)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Tunnelbanestationer på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Tunnelbanestationer av";
                    }
                    var subwayFileName = "SubwayText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + subwayFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleButtonBusStop)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Busshållplatser på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Busshållplatser av";
                    }
                    var busStopFileName = "BusStopText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + busStopFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleButtonChargingStation)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Laddningstationer på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Laddningstationer av";
                    }
                    var chargingStationFileName = "ChargingStationText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + chargingStationFileName, text);
                    }
                }
                else if (toggle.Id == Resource.Id.toggleButtonHotel)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Hotell/Vandrarhem på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Hotell/Vandrarhem av";
                    }
                    var hotelFileName = "HotelText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + hotelFileName, text);
                    }
                }
                else if(toggle.Id==Resource.Id.toggleVibration)
                {
                    string text;
                    if (toggle.Checked == true)
                    {
                        //Activate or show on map if checked
                        text = "Vibration på";
                    }
                    else
                    {
                        //De-activate or hide from map if not checked
                        text = "Vibration av";
                    }
                    var vibrationFileName = "VibrationText.txt"; //Change the string value of fileName to match what the user (un)checked and add "Text.txt" to the end (for example, if user (un)checks "Resturanger", so should the value change to "ResturantText.txt", file-format might or might not need to be changed in the future. I recommend doing this in an if-statement that checks which ToggleButton the user pressed
                    var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the filepath
                    if (Directory.Exists(documents) == false) //Checks whether or not this file already exists, IF it does NOT exist so will it write on a new file
                    {
                        File.WriteAllText(documents + @"/" + vibrationFileName, text);
                    }
                }
            }
            catch (Exception e)
            {
                //Add specific exceptions we are expecting might happen if we somehow fucked up
            }
            finally
            {
                SaveFile();
            }
        }
        [Java.Interop.Export("ReadFile")]
        public void ReadFile()
        {
            try
            {
                var textFileName = "TextText.txt"; //Create a seperate fileName-variable for every file we know will be created. REMEMBER TO ADD NEW fileName-variables IF WE WANNA ADD MORE ToggleButtons IN THE Settings AND MapSettings view
                var onlineFileName = "OnlineText.txt";
                var resturantFileName = "ResturantText.txt";
                var subwayFileName = "SubwayText.txt";
                var busStopFileName = "BusStopText.txt";
                var chargingStationFileName = "ChargingStationText.txt";
                var hotelFileName = "HotelText.txt";
                var vibrationFileName = "VibrationText.txt";
                var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the file path
                if (Directory.Exists(documents) == false) //Checks whether or not the file actually exists, put this inside the if-statement already in use
                {
                    //DO NOT GO ON WITH THIS METHOD!
                    return;
                }
                var newTextText = (documents + @"/" + textFileName); //See the example below
                var newOnlineText = (documents + @"/" + onlineFileName);
                var newResturantText = (documents + @"/" + resturantFileName);
                var newSubwayText = (documents + @"/" + subwayFileName);
                var newBusStopText = (documents + @"/" + busStopFileName);
                var newChargingStationText = (documents + @"/" + chargingStationFileName);
                var newHotelText = (documents + @"/" + hotelFileName);
                var newVibrationText = (documents + @"/" + vibrationFileName);
                //exit the if-statement here
                //ENTER EXAMPLE
                /* var resturantName="ResturantText.txt";
                   var documents=System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);  
                   if(Directory.Exists(documents)==false)
                   {
                      return;
                   }
                   var newText=(documents+@"/"+resturantName);*/
                //EXIT EXAMPLE
            }
            catch (Exception e)
            {
                //Add specific exceptions we are expecting might happen if we somehow fucked up
            }
            finally
            {
                SaveFile();
            }
        }
        [Java.Interop.Export("SaveFile")]
        public void SaveFile()
        {
            try
            {
                var documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Follows the file path
                /*if (Directory.Exists(documents) == false) //Checks whether or not the file exist, IF it doesn't exist so will it create the file
                {
                    File.Create(documents);
                }*/
            }
            catch (Exception e)
            {
                //Add specific exceptions we are expecting might happen if we somehow fucked up
            }
            finally
            {
                //DO NOTHING
            }
        }
    }
}