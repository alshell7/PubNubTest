Imports System.Net.NetworkInformation
Imports PubNubMessaging.Core
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Dim MyPubnub As Pubnub
    Public ChannelName As String = "PubnubTest"

    Private ReadOnly PublishKey As String = ""
    Private ReadOnly SubscribeKey As String = ""
    Private ReadOnly SecretKey As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (IsNetworkAvailable()) Then
            Log("Network Available")
            ChannelNameTextBox.Text = ChannelName
            ChannelNamePublishTextBox.Text = ChannelName
            MyPubnub = New Pubnub(PublishKey, SubscribeKey, SecretKey)
            Log("Pubnub has been initialised.")
            'Subscribe()

        Else
            Log("Network Not Available")
            MsgBox("Network Not Available")
            Me.Close()
        End If
        CheckForIllegalCrossThreadCalls = False
    End Sub

    'Public Delegate Sub DelegateDisplayReturnMessage(result As String)


    Dim errorCallBack As Action(Of PubnubClientError) = AddressOf OnErrorCallback

    Dim connectCallBack As Action(Of String) = AddressOf OnConnectMessage
    Dim disconnectCallBack As Action(Of String) = AddressOf OnDisconnectStatusMessage

    Private Sub Publish()
        Log("About to set up publish..")
        Dim userCallBack As Action(Of String) = AddressOf OnUserCallback
        '        Dim subscribeCallBack As Action(Of String) = AddressOf OnSubscribeMessageRecievedCallBack
        MyPubnub.Publish(Of String)(ChannelNamePublishTextBox.Text, MessageTextBox.Text, userCallBack, errorCallBack)
    End Sub

    Private Sub Subscribe()
        ChannelName = ChannelNameTextBox.Text
        Log("About subscribe to channel:" & ChannelName)
        Dim subscribeCallBack As Action(Of String) = AddressOf OnSubscribeMessageRecievedCallBack
        MyPubnub.Subscribe(Of String)(ChannelName, subscribeCallBack, connectCallBack, errorCallBack)

    End Sub


    Private Sub Unsubscribe()
        Log("Unsubscribing from channel:" & ChannelName)
        'MyPubnub.Unsubscribe(Of String)(ChannelName, subscribeCallBack, connectCallBack, AddressOf DisplayDisconnectStatusMessage)
        'MyPubnub.Unsubscribe(ChannelName, subscribeCallBack, connectCallBack, disconnectCallBack, errorCallBack)
    End Sub

    Private Sub OnUserCallback(result As String)
        Log("OnUserCallback:" & result)
        Log("Message sent!")
    End Sub

    Private Sub OnErrorCallback(errorPubnub As PubnubClientError)
        Log("Error Occurred:")
        Log(errorPubnub.Description)
        Log("Is DotNet Exception?:" & IIf(errorPubnub.IsDotNetException, "Yes", "No"))
    End Sub


    Private Sub OnSubscribeMessageRecievedCallBack(detail As String)
        Log("OnSubscribeMessageRecievedCallBack:" & detail)
        Try
            Dim mJson As JArray = JArray.Parse(detail)

            Dim reader As JsonReader = mJson.CreateReader
            Dim values As New List(Of String)
            While reader.Read
                If (Not String.IsNullOrEmpty(CType(reader.Value, String))) Then
                    values.Add(CType(reader.Value, String))
                    Console.WriteLine("Value: {0}, Path {1}", CType(reader.Value, String), reader.Path)

                End If
            End While
            Log("Message Recieved!")
            'values.ForEach(AddressOf AddMessage)

            ReceivedMessagesListBox.Items.Add("Received : " & values.First & " @" & GetCurrentTime())
            'Dim c As DelegateAdd = AddressOf AddMessage
            'c("Message recieved")
            'Me.BeginInvoke(c)
            'AddMessage(values.First)
            'Dim x As DialogResult = MessageBox.Show(values.First, "Pubnub", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'If x = Windows.Forms.DialogResult.OK Then
            '    Log("Update")
            '    'ReceivedMessagesListBox.Items.Add("Message Recieved!")
            '    'PublishButton.Text = "asdvasd ad "

            '    AddMessage()
            'End If
        Catch Rex As JsonReaderException
            MsgBox(Rex.Message)
            Console.WriteLine(Rex.Message)
        Catch ex As JsonException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Delegate Sub DelegateAdd(str As String)
    'Public Sub AddMessage(str As String)
    '    'Dim x As New ListBox()
    '    'x = ReceivedMessagesListBox
    '    'x.Items.Add("Test")
    '    'ReceivedMessagesListBox = x        
    '    'ReceivedMessagesListBox.Items.Add(str)
    '    'ReceivedMessagesListBox.Update()
    '    Log(str)

    'End Sub
    Private Sub OnConnectMessage(result As String)
        Log("OnConnectMessage: " & result)
        Log("Subscribtion Transacted!")
    End Sub

    Private Sub OnDisconnectStatusMessage(result As String)
        Log("OnDisconnectStatusMessage:" & result)
    End Sub

    Public Sub Log(ByVal data As String)
        Console.WriteLine(data)
        'Try
        '    ReceivedMessagesListBox.Items.Add(data)
        'Catch ex As InvalidOperationException
        '    Console.WriteLine("Error logging..")
        '    Console.WriteLine(ex.Message)
        'End Try

    End Sub

    Public Shared Function GetCurrentTime() As String
        Return Date.Now.ToShortTimeString
    End Function
    Public Shared Function IsNetworkAvailable()
        Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim networkAvailable As Boolean = False
        For Each mInterface In interfaces
            ' Log(mInterface.Name & ", " & mInterface.Description & ", status: " & mInterface.OperationalStatus)
            If (mInterface.Name.Contains("Wi-Fi")) Then
                If (mInterface.OperationalStatus = OperationalStatus.Up) Then
                    networkAvailable = True
                End If
            End If
        Next
        Return networkAvailable
    End Function

    Public Class ReceivedMessage
        Public message As String
        Public id As String
        Public channel As String
    End Class

    Private Sub SubscribeButton_Click(sender As Object, e As EventArgs) Handles SubscribeButton.Click
        If (IsNetworkAvailable()) Then
            Subscribe()
        Else
            MsgBox("Not connected to internet!")
        End If
    End Sub

    Private Sub PublishButton_Click(sender As Object, e As EventArgs) Handles PublishButton.Click
        If (IsNetworkAvailable()) Then
            Publish()

            ReceivedMessagesListBox.Items.Add("Sent message" & " @" & GetCurrentTime())

        Else
            MsgBox("Not connected to internet!")
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("Fork me on https://github.com/alshell7/PubNubTest")
    End Sub
End Class
