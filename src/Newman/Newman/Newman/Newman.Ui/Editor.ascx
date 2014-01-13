<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Editor.ascx.cs" Inherits="Newman.Newman.Ui.Editor" %>
<label for="name">Name</label><input type="text" id="emailName" name="emailName" />
<label for="subject">Subject</label><input type="text" id="subject" name="subject" />
<label for="toAddress">To Address</label><input type="text" id="toAddress" name="toAddress" />

<input type="textarea" id="emailBody" name="emailBody" rows="20"/>

<div id="output"></div>

<button  name="Save">Save</button>


