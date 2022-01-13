# MKVRemux-Reworked
This will basically change based on a few possibilities:
<ul>
  <li>I need it to do something it can't yet</li>
  <li>Someone happens to request something or finds a bug</li>
  <li>I happen to have time to mess with it.</li>
</ul>

<h2>How to use:<br></h2>
<ul>
  <li>Choose an input path</li>
  <li>Choose an output path</li>
  <li>Click Precheck</li>
  <ul>
     <li>If you want to find a track based on the name and set the language to japanese click the check box next to Search name, and set the dropdown to the language you would like the tracks changed to.</li>
     <li>If you want to find a track based on the language type in the Search Language box, and set the dropdown to the language you would like the tracks changed to.</li>
     <li>If you want to find a track based on the track number, type the number in the Search track field, and set the dropdown to the language you want to change it to.  You can also use the text box to the right of the Select Track dropdown to change the track number of a specific track.</li>
  </ul>
  <li>Click Precheck Again after you do the above.  In the list, you should see you changes applied after it processes.</li>
  <li>If everything looks good, click Remux. This will create a batch file under the output folder.</li>
  <li>Double click the .bat file that was created under the output folder. (you can also open this file if you want to see what it is intending to do)</li>
  <li>After the .bat file is doubleclicked you will see a cmd window pop up and you can see the progress of the remuxing there. (I plan to internalize this process into the program sometime, but it is not implemented yet.</li>
</ul>

Note: For all the combo boxes if the language you want to change it to it not listed, just type it in the box.<br>
Note 2: I will tooltip all this...sometime...when I have the free time.

<hr>
Planned Changes
<ul>
  <li><s>Folder Chooser buttons for Input and Output Directoryies</s></li>
  <li>Audio Language change support</li>
  <li><s>Better Error Handling</s></li>
  <li>Run conversion in program instead of clicking a batch it makes</li>
</ul>
<hr>
<p>
If you don't know the current tracks and such, you can click the precheck button.
This will give you a list of all the mkv files in the input directory along with their track info for sub tracks (This may change to include audio later)

Once you have figured out the combination of things you need to do to set the tracks the way you want, click remux.
Currently this created a batch file in the output directory that you need to run manually.

Depending on how the tracks are named or not named, you may have to process the files a couple times.</p>
