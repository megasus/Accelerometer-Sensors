Imports Windows.Devices.Sensors
Imports System.Threading

Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainH()
    End Sub
    Sub MainH()
        Dim trd As New Thread(AddressOf CheckOrientation)
        Dim accelero As Accelerometer = Accelerometer.GetDefault()
        If Not accelero Is Nothing Then
            trd.Start(accelero)
        Else
            MsgBox("No Accelerometer!")
        End If
    End Sub

    Public Delegate Sub ProgressDelegate(bar As ProgressBar, val As Double)
    Public Sub SetProgress(bar As ProgressBar, val As Double)
        If val > bar.Maximum Then bar.Maximum = val
        bar.Value = val
    End Sub

    Public Delegate Sub LabelDelegate(lbl As Label, val As String)
    Public Sub SetLabel(lbl As Label, val As String)
        lbl.Text = val
    End Sub

    Dim currentOrientation As Integer = 0

    Private Sub CheckOrientation(ByVal accelero As Accelerometer)
        Do
            Thread.Sleep(500)
            Try
                Dim reading As AccelerometerReading = accelero.GetCurrentReading()
                With reading
                    If .AccelerationX * 1000 < 500 And .AccelerationX * 1000 > -500 Then
                        If .AccelerationY * 1000 < -200 Then
                            If .AccelerationZ * 1000 < 0 Then
                                '// A
                                If currentOrientation <> 1 Then
                                    currentOrientation = 1
                                    orientation_lbl.BeginInvoke(New LabelDelegate(AddressOf SetLabel), orientation_lbl, "Landscape A")
                                End If
                            End If
                        ElseIf .AccelerationY * 1000 > 200 Then
                            If .AccelerationZ * 1000 < -200 Then
                                '// C
                                If currentOrientation <> 2 Then
                                    currentOrientation = 2
                                    orientation_lbl.BeginInvoke(New LabelDelegate(AddressOf SetLabel), orientation_lbl, "Landscape C")
                                End If

                            End If
                        End If
                    ElseIf .AccelerationX * 1000 > 0 Then
                        If .AccelerationY * 1000 < 400 And .AccelerationY > -400 Then
                            If .AccelerationZ * 1000 < 0 Then
                                '// B
                                If currentOrientation <> 3 Then
                                    currentOrientation = 3
                                    orientation_lbl.BeginInvoke(New LabelDelegate(AddressOf SetLabel), orientation_lbl, "Porträt B")
                                End If

                            End If
                        End If
                    ElseIf .AccelerationX * 1000 < 0 Then
                        If .AccelerationY * 1000 < 400 And .AccelerationY > -400 Then
                            If .AccelerationZ * 1000 < 0 Then
                                '// D
                                If currentOrientation <> 4 Then
                                    currentOrientation = 4
                                    orientation_lbl.BeginInvoke(New LabelDelegate(AddressOf SetLabel), orientation_lbl, "Porträt D")
                                End If

                            End If
                        End If
                    End If
                End With
                Try
                    With reading
                        Label6.BeginInvoke(New LabelDelegate(AddressOf SetLabel), Label6, .AccelerationX.ToString())
                        Label5.BeginInvoke(New LabelDelegate(AddressOf SetLabel), Label5, .AccelerationY.ToString())
                        Label4.BeginInvoke(New LabelDelegate(AddressOf SetLabel), Label4, .AccelerationZ.ToString())
                        If .AccelerationX < 0 Then
                            ProgressBar1.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar1, 0)
                            ProgressBar6.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar6, .AccelerationX * -1000)
                        Else
                            ProgressBar6.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar6, 0)
                            ProgressBar1.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar1, .AccelerationX * 1000)
                        End If
                        If .AccelerationY < 0 Then
                            ProgressBar2.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar2, 0)
                            ProgressBar5.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar5, .AccelerationY * -1000)
                        Else
                            ProgressBar5.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar5, 0)
                            ProgressBar2.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar2, .AccelerationY * 1000)
                        End If
                        If .AccelerationZ < 0 Then
                            ProgressBar3.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar3, 0)
                            ProgressBar4.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar4, .AccelerationZ * -1000)
                        Else
                            ProgressBar4.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar4, 0)
                            ProgressBar3.BeginInvoke(New ProgressDelegate(AddressOf SetProgress), ProgressBar3, .AccelerationZ * 1000)
                        End If
                    End With
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            Catch ex As Exception
                MsgBox(ex)
            End Try

        Loop
    End Sub
End Class