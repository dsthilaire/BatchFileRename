# BatchFileRename
Utility for renaming files in bulk.  I created this for use in conjunction with the Mp3ToUsb application.  When I rip CD's in Windows Media Player, I have to select one of their delimiters for my filenames.  I choose "-", but I want it to be " - ".  This app allows me to change all the "-"s to " - "s in all the files ripped from the CD.

## Input Files listbox
Here is where you add the files that need to be renamed.  Simply drag them from Windows Explorer and drop them into the listbox.

## Remove Selected / Remove All
These buttons remove filenames from the listbox.

## Replace/with
These textboxes are where you specify how the files are to be renamed.  The first is where you enter the string that will be searched for in the input filenames.  The second is where you specify the string that will be used to replace the text that was searched for.  The second textbox can be left blank if you just want to remove substrings from the filename.  Only the filename is searched and modified -- not the extension, and not the path.

The app also allows the use of regular expressions.  If the first character in the Replace textbox is '/', then the rest of the text in that textbox will be treated as a regular expression and the text in the second textbox will be treated as a replacement pattern.  So, if your regular expression contains groups, then your replacement pattern can have substitutions that reference those groups.

## Rename Files
This button is used to kick off the process after all the inputs are entered.
