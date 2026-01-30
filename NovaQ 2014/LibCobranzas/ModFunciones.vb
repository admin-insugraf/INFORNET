Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing

Module ModFunciones
    Public Sub OnlyNum(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub Formatea_grilla(ByVal grilla As System.Windows.Forms.DataGridView)
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66)
        grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.EnableHeadersVisualStyles = False
        grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grilla.ColumnHeadersHeight = 30

        grilla.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66)
        grilla.RowHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Public Function Primer_Dia_Mes(ByVal Fecha As Date) As Date
        Primer_Dia_Mes = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
    End Function
    Public Function Ultimo_Dia_Mes(ByVal Fecha As Date) As Date
        Ultimo_Dia_Mes = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
    End Function
    Public Function Copiar_Archivos(ByVal _ruta_origen As String, ByVal _ruta_destino As String) As Boolean
        Dim var1 As String = "" ' Variable para almacenar la direccion del documento
        Dim var2 As String = "" 'Variable utilizada para guardar la direccion de la carpeta de destino final.
        Dim variable As String = "" ' Almacena el nombre del archivo PDF 
        Dim nuevo As String = "" ' variable utilizada para almacenar la ruta final del documento copiado

        var1 = _ruta_origen
        var2 = _ruta_destino

        Try
            variable = Mid(var1, InStrRev(var1, "\"))
            nuevo = var2 + variable
            File.Copy(var1, nuevo, True)
            Return True
        Catch ex As Exception
            MsgBox("Error", ex.Message)
            Return False
        End Try
    End Function
    Function OnlyDecimal(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Text As TextBox) As Integer
        Dim dig As Integer = Len(Text.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        ' se verifica si es un digito o un punto 
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return a
        Else
            e.Handled = True
        End If
        ' se verifica que el primer digito ingresado no sea un punto al seleccionar
        If Text.SelectedText <> "" Then
            If e.KeyChar = "." Then
                e.Handled = True
                Return a
            End If
        End If
        If dig = 1 And e.KeyChar = "." Then
            e.Handled = True
            Return a
        End If
        'aqui se hace la verificacion cuando es seleccionado el valor del texto
        'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
        If Text.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(Text.Text & e.KeyChar)
                If car.Substring(a, 1) = "." Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                If NumDecimales >= 4 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
            Next
        End If
    End Function
    Public Function NullStr(ByVal STRVal As Object) As String
        If STRVal Is Nothing Or IsDBNull(STRVal) Then
            Return ""
        Else
            Return STRVal
        End If
    End Function
    Public Function NullDbl(ByVal DBLVal As Object) As Double
        If DBLVal Is Nothing Then
            Return 0
        Else
            Return DBLVal
        End If
    End Function
    Public Function NUMLET(ByRef Num As Double) As String
        Dim cLET As String
        Dim cWork As String
        Dim cUNIDAD As String
        Dim cDECENA As String
        Dim cCENTENA As String
        Dim nMODULUS As Short
        Dim nI As Short
        Dim nK As Short
        Dim Lit1 As String
        Dim Lit2 As String
        Dim Lit3 As String
        Dim Lit4 As String
        Dim Lit5 As String
        Lit1 = "Uno    Dos    Tres   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
        Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
        Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
        Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
        Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"

        'Proceso Input = Num , Output = Let

        cLET = ""
        If Num > 0.99 Then
            'Separa los Enteros en una Cadena de Caracteres
            If InStr(1, Trim(Str(Num)), ".", 0) > 0 Then
                cWork = Mid(Trim(Str(Num)), 1, InStr(1, Trim(Str(Num)), ".", 0) - 1)
            Else
                cWork = Str(Num)
            End If
            nMODULUS = Int(Len(Trim(cWork)) / 3)
            nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)

            If nMODULUS > 0 Then
                cWork = New String("0", 3 - nMODULUS) & Trim(cWork)
            End If

            nK = (Len(Trim(cWork)) / 3) - 1
            'Procesa de Mil en Mil
            nI = 1
            Do While nI < Len(Trim(cWork)) - 1
                cCENTENA = Mid(Trim(cWork), nI, 1)
                cDECENA = Mid(Trim(cWork), nI + 1, 1)
                cUNIDAD = Mid(Trim(cWork), nI + 2, 1)
                'Centenas
                If cCENTENA <> "0" Then
                    If cCENTENA = "1" Then
                        cLET = cLET & "Cien "
                        If cDECENA <> "0" Or cUNIDAD <> "0" Then
                            cLET = Mid(cLET, 1, Len(cLET) - 1) & "to "
                        End If
                    Else
                        If CDbl(cCENTENA) = 2 Or CDbl(cCENTENA) = 3 Then '2003/04/04: marco cambia
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "cientos " '2003/04/04: Erika cambia
                        Else
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                        End If
                        'cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                    End If
                End If
                'Decenas
                If cDECENA <> "0" Then
                    If cDECENA = "1" And cUNIDAD <> "0" Then
                        If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
                    Else
                        If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
                    End If
                End If
                'Unidades
                If cUNIDAD <> "0" Then
                    If cDECENA > "1" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 1) & "i"
                        If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                    Else
                        If cDECENA < "1" Then
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET & Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
                        End If
                    End If
                End If
                cLET = cLET & " "
                'Pone Miles o Millones
                If nK > 0 Then
                    If cCENTENA & cDECENA & cUNIDAD = "001" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
                    End If
                    nMODULUS = Int(nK / 2)
                    nMODULUS = nK - (nMODULUS * 2)
                    If nMODULUS = 0 Then
                        cLET = cLET & Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))
                        If Not (cCENTENA & cDECENA & cUNIDAD = "001") Or Num > 1999999 Then
                            cLET = cLET & "es "
                        Else
                            cLET = cLET & " "
                        End If
                    Else
                        If cCENTENA & cDECENA & cUNIDAD > "000" Then
                            cLET = cLET & "Mil "
                        End If
                    End If
                    nK = nK - 1
                End If
                nI = nI + 3
            Loop
            cLET = cLET & "Y "
        End If
        If InStr(1, Trim(Str(Num)), ".", 0) > 0 Then
            cLET = cLET & Mid(Trim(Microsoft.VisualBasic.Format(Num, ".00")), InStr(1, Trim(Microsoft.VisualBasic.Format(Num, ".00")), ".", 0) + 1, 2) & "/100" & " "
        Else
            cLET = cLET & "00/100" & " "
        End If
        NUMLET = cLET
    End Function

    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 1)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function
End Module
