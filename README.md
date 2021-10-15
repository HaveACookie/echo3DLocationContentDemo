<H1>echo3DLocationContentDemo</H1>


<H1>Register</H1>
<p>Don't have an API key? Make sure to register for FREE at echo3D</p>

<H1>Setup</H1>

<ul>
<li>Create a New Unity Project.</li>
<li><a href="https://docs.echo3d.co/unity/installation">Install the Echo3D SDK.</a></li>
<li>Open the sample scene under <code> echo3D/Examples/sample.unity </code>.</li>
<li><a href="https://docs.echo3d.co/unity/using-the-sdk">Set the API key</a> in the Inspector of the echo3D game object.</li>
<li><a href="https://docs.echo3d.co/quickstart/add-a-3d-model">Add the 3D model</a> from the models folder to the console(set these models to appear at a specific location in the console).</li>
<li><a href="https://docs.echo3d.co/unity/adding-ar-capabilities">Follow these directions</a> to enable AR capability in your sample scene.</li>
<li>Create a canvas as a child to the main camera along with a panel and text as chilren of the canvas</li>
<li> Add GPS.cs and UpdateGPSText.cs scripts to the main camera and assign the text you created as the cordinates section of UpdateGPSText in the inspector.</li>
<li> Modify cordinates.text in UpdateGPSText.cs in order to customize the UI content that displays at a particular location.</li>
<li> Use GPS.Instance.latitutde and GPS.Instance.longitude to show other custom content that displays when your phone is at a particular location (this could be objects, media, or even minigames</li>
<li>Create a canvas as a child to the main camer</li>
</ul>

<H1>Run</H1>
<p> Build this project in XCode and run it on your phone. Ensure your target device in your Project Settings (you can find this under build settings/project settings/ player) is Iphone+IPad and have "automatically add capabilities" enabled. Please also set your Architecture to be universal.</p>

<H1>Support</H1>
<p>Feel Free to reach out at support@echo3d.co or join our support channel on Slack.</p>
