<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SubscribeButton = New System.Windows.Forms.Button()
        Me.ChannelNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReceivedMessagesListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.PublishButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChannelNamePublishTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SubscribeButton
        '
        Me.SubscribeButton.Location = New System.Drawing.Point(12, 39)
        Me.SubscribeButton.Name = "SubscribeButton"
        Me.SubscribeButton.Size = New System.Drawing.Size(331, 23)
        Me.SubscribeButton.TabIndex = 1
        Me.SubscribeButton.Text = "&Subscribe"
        Me.SubscribeButton.UseVisualStyleBackColor = True
        '
        'ChannelNameTextBox
        '
        Me.ChannelNameTextBox.Location = New System.Drawing.Point(101, 13)
        Me.ChannelNameTextBox.Name = "ChannelNameTextBox"
        Me.ChannelNameTextBox.Size = New System.Drawing.Size(242, 20)
        Me.ChannelNameTextBox.TabIndex = 0
        Me.ChannelNameTextBox.Text = "PubnubTest"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Channel Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Messages Received:"
        '
        'ReceivedMessagesListBox
        '
        Me.ReceivedMessagesListBox.FormattingEnabled = True
        Me.ReceivedMessagesListBox.Location = New System.Drawing.Point(12, 87)
        Me.ReceivedMessagesListBox.Name = "ReceivedMessagesListBox"
        Me.ReceivedMessagesListBox.Size = New System.Drawing.Size(328, 95)
        Me.ReceivedMessagesListBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Message To Send :"
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Location = New System.Drawing.Point(12, 208)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(331, 62)
        Me.MessageTextBox.TabIndex = 8
        '
        'PublishButton
        '
        Me.PublishButton.Location = New System.Drawing.Point(12, 316)
        Me.PublishButton.Name = "PublishButton"
        Me.PublishButton.Size = New System.Drawing.Size(331, 23)
        Me.PublishButton.TabIndex = 9
        Me.PublishButton.Text = "&Publish"
        Me.PublishButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(268, 345)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Channel Name:"
        '
        'ChannelNamePublishTextBox
        '
        Me.ChannelNamePublishTextBox.Location = New System.Drawing.Point(98, 290)
        Me.ChannelNamePublishTextBox.Name = "ChannelNamePublishTextBox"
        Me.ChannelNamePublishTextBox.Size = New System.Drawing.Size(242, 20)
        Me.ChannelNamePublishTextBox.TabIndex = 12
        Me.ChannelNamePublishTextBox.Text = "PubnubTest"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 379)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChannelNamePublishTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.PublishButton)
        Me.Controls.Add(Me.ReceivedMessagesListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChannelNameTextBox)
        Me.Controls.Add(Me.SubscribeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pubnub Demonstration In Visual Basic.Net"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubscribeButton As System.Windows.Forms.Button
    Friend WithEvents ChannelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReceivedMessagesListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublishButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChannelNamePublishTextBox As System.Windows.Forms.TextBox

End Class
