# MKVRemux-Reworked
This will basically change based on a few possibilities:
<ul>
  <li>I need it to do something it can't yet</li>
  <li>Someone happens to request something or finds a bug</li>
  <li>I happen to have time to mess with it.</li>
</ul>

<h2>How to use:<br></h2>
<ul>
  <li>Make sure you have MkvToolNix installed - https://mkvtoolnix.download/</li>  
  <li>Choose an input path</li>
  <li>The output path will autofill based on the input path, or you can override it with your own path.</li>
  <li>There are check boxes for:
    <ul>
      <li>Include Sub Directories - will scan subdirectories under the input path for mkv files also</li>
      <li>Keep Batch - This will keep the batch file after auto processing.</li>
      <li>Batch Only - This will make a batch only and not auto process. This can be useful for making a large batch that you can either run separatly or uncheck this on the last set you wish to batch to run them all automatically.</li>
    </ul>
  </li>
  <li>Click Precheck</li>
  <ul>
     <li>If you want to find a track based on the name and set the language to japanese click the check box next to Search name, and set the dropdown to the language you would like the tracks changed to.</li>
     <li>If you want to find a track based on the language type in the Search Language box, and set the dropdown to the language you would like the tracks changed to.</li>
     <li>If you want to find a track based on the track number, type the number in the Search track field, and set the dropdown to the language you want to change it to.  You can also use the text box to the right of the Select Track dropdown to change the track number of a specific track.</li>
  </ul>
  <li>Click Precheck Again after you do the above.  In the list, you should see you changes applied after it processes.</li>
  <li>If everything looks good, click Remux.</li>
</ul>

Note: For all the combo boxes if the language you want to change it to it not listed, just type it in the box.<br>
Note 2: I will tooltip all this...sometime...when I have the free time.

<hr>
Planned Changes
<ul>
  <li><s>Folder Chooser buttons for Input and Output Directoryies</s></li>
  <li>Audio Language change support</li>
  <li><s>Better Error Handling</s></li>
  <li><s>Run conversion in program instead of clicking a batch it makes</s></li>
</ul>
<hr>
<p>
If you don't know the current tracks and such, you can click the precheck button.
This will give you a list of all the mkv files in the input directory along with their track info for sub tracks (This may change to include audio later)
Pick the change you want to make and click Precheck again.

Once you have figured out the combination of things you need to do to set the tracks the way you want, click remux.</p>
