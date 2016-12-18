Namespace adb_control
    Namespace phoneinfo
        Class build_prop


            Public Function GetProp(item As String) As String
                Return New ADB().ADBExecute("shell getprop " + item)
            End Function


            Public Function GetPhoneModel() As String
                Return New ADB().ADBExecute("shell getprop ro.product.model").ToString
            End Function


            Public Function SetPhoneModel()
                Return New ADB().ADBExecute("shell setprop ro.product.model")
            End Function


            Public Function GetPhoneName() As String
                Return New ADB().ADBExecute("shell getprop ro.product.name").ToString
            End Function


            Public Function SetPhoneName()
                Return New ADB().ADBExecute("shell setprop ro.product.name")
            End Function


            Public Function GetPhoneBrand() As String
                Return New ADB().ADBExecute("shell getprop ro.product.brand").ToString
            End Function


            Public Function GetPhoneManafacture() As String
                Return New ADB().ADBExecute("shell getprop ro.product.manufacturer").ToString
            End Function


            Public Function GetPhoneAndroidVersion() As String
                Return New ADB().ADBExecute("shell getprop ro.build.version.release").ToString
            End Function


            Public Function GetPhoneLanguage() As String
                Return New ADB().ADBExecute("shell getprop ro.product.locale.language").ToString
            End Function


            Public Function SetPhoneLanguage()
                Return New ADB().ADBExecute("shell setprop ro.product.locale.language")
            End Function


            Public Function GetPhoneCountry() As String
                Return New ADB().ADBExecute("shell getprop ro.product.locale.region").ToString
            End Function


            Public Function GetPhoneKernelInfo() As String
                Return New ADB().ADBExecute("shell cat /proc/version").ToString
            End Function


            Public Function GetPhoneIMEIInfo() As String
                'may not work in rooted device
                Return New ADB().ADBExecute("shell dumpsys iphonesubinfo").ToString
            End Function
        End Class


        Class System

            'TODO: multi device support
            Public Function GetPhoneSerial() As String
                Return Split(New ADB().ADBExecute("devices").Replace(vbCrLf, "").Replace(" ", "").Replace("Listofdevicesattached", ""), Chr(9))(0)
            End Function


            Public Function GetCurrentPhoneMode() As String
                Return Split(New ADB().ADBExecute("devices").Replace(vbCrLf, "").Replace(" ", "").Replace("Listofdevicesattached", ""), Chr(9))(1)
            End Function

        End Class
        Namespace Hardware
            Class CPU

                Private Function RawCPUStat() As String
                    Dim adb_ As New ADB("shell top")
                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream
                        Dim Block As String = adb_.StandardOutput.ReadLine

                        If Block.Contains("%") Then
                            Return Block
                        End If

                    End While

                    Return Nothing
                End Function


                Public Function GetUserCPUStat() As Integer
                    Return CInt(Split(Split(RawCPUStat(), "User ")(1), ",")(0).Replace("%", ""))
                End Function


                Public Function GetSystemCPUStat() As Integer
                    Return CInt(Split(Split(RawCPUStat(), "System ")(1), ",")(0).Replace("%", ""))
                End Function


                Public Function GetIOWCPUStat() As Integer
                    Return CInt(Split(Split(RawCPUStat(), "IOW ")(1), ",")(0).Replace("%", ""))
                End Function


                Public Function GetIRQCPUStat() As Integer
                    Return CInt(Split(Split(RawCPUStat(), "IRQ ")(1), ",")(0).Replace("%", ""))
                End Function


                Public Function GetTotalCPUStat() As Integer
                    Return GetUserCPUStat() + GetSystemCPUStat() + GetIOWCPUStat() + GetIRQCPUStat()
                End Function


            End Class

            Class RAM

                'NOTE: rawm stats are provided by kB.

                Private Function RawRAMstat(DumpsysParseParameter As String) As Integer

                    Dim adb_ As New ADB("shell dumpsys meminfo")
                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream
                        Dim Block As String = adb_.StandardOutput.ReadLine
                        If Block.Contains(DumpsysParseParameter) Then
                            Return CInt(Split(Split(Block, DumpsysParseParameter)(1), " kB")(0))
                        End If
                    End While
                    Return Nothing

                End Function


                Public Function TotalRAMstat() As Integer
                    Return RawRAMstat("Total RAM: ")
                End Function


                Public Function LostRAMstat() As Integer
                    Return RawRAMstat("Lost RAM: ")
                End Function


                Public Function FreeRAMstat() As Integer
                    Return RawRAMstat("Free RAM: ")
                End Function


                Public Function UsedRAMstat() As Integer
                    Return RawRAMstat("Used RAM: ")
                End Function


            End Class

            Class Battery

                Private Function RawBatterystat(DumpsysParseParameter As String) As String

                    Dim adb_ As New ADB("shell cat /sys/class/power_supply/battery/*")
                    adb_.Start()

                    While Not adb_.StandardOutput.EndOfStream

                        Dim Block As String = adb_.StandardOutput.ReadLine

                        If Block.Contains(DumpsysParseParameter + "=") Then
                            Return Split(Block, DumpsysParseParameter + "=")(1)
                        End If

                    End While

                    Return Nothing
                End Function


                Public Function IsPhoneCharging() As Boolean

                    If RawBatterystat("POWER_SUPPLY_CHARGING_STATUS") = "Charging" Then
                        Return True
                    End If

                    Return False
                End Function


                Public Function RemainingBatteryByPercentage() As Integer
                    Return CInt(RawBatterystat("POWER_SUPPLY_CAPACITY"))
                End Function


                Public Function IsBatteryHealthGood() As Boolean

                    If RawBatterystat("POWER_SUPPLY_HEALTH") = "Good" Then
                        Return True
                    End If

                    Return False
                End Function


                Public Function ChargingVoltageBymA() As Integer
                    Return CInt(RawBatterystat("POWER_SUPPLY_CURRENT_NOW"))
                End Function


                Public Function BatterySizeByMAH() As Integer
                    Return CInt(RawBatterystat("POWER_SUPPLY_CHARGE_FULL_DESIGN"))
                End Function


                Public Function BatteryTechnology() As String
                    Return RawBatterystat("POWER_SUPPLY_TECHNOLOGY")
                End Function

            End Class

            Class Storage
                'TODO: finish this class
            End Class
        End Namespace
    End Namespace
    End Namespace
