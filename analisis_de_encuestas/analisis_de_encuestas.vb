Imports System
Module analisis_de_encuestas
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim preguntas(9) As String
        Dim respuestasA(9) As Integer
        Dim respuestasB(9) As Integer
        Dim respuestasC(9) As Integer
        Dim respuestasD(9) As Integer
        Dim totalesRespuestas(9) As Integer
        Dim respuestasGanadoras(9) As String
        Dim porcentajesGanadores(9) As Double
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------'
        '--|menu_principal_analisis_de_encuestas|--'
        '------------------------------------------'
        Do
            Console.WriteLine("menu principal analisis de encuestas")
            Console.WriteLine("1) Registrar encuesta")
            Console.WriteLine("2) Editar encuesta")
            Console.WriteLine("3) Listar encuestas")
            Console.WriteLine("4) Buscar encuesta")
            Console.WriteLine("5) Eliminar encuesta")
            Console.WriteLine("6) Mostrar analisis")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------'
                '--|registrar_encuesta|--'
                '------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas encuestas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Pregunta: ")
                        preguntas(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad de respuestas A: ")
                        respuestasA(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Cantidad de respuestas B: ")
                        respuestasB(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Cantidad de respuestas C: ")
                        respuestasC(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Cantidad de respuestas D: ")
                        respuestasD(cantidad) = Convert.ToInt32(Console.ReadLine())
                        totalesRespuestas(cantidad) = respuestasA(cantidad) + respuestasB(cantidad) + respuestasC(cantidad) + respuestasD(cantidad)
                        If respuestasA(cantidad) >= respuestasB(cantidad) And respuestasA(cantidad) >= respuestasC(cantidad) And respuestasA(cantidad) >= respuestasD(cantidad) Then
                            respuestasGanadoras(cantidad) = "A"
                        ElseIf respuestasB(cantidad) >= respuestasA(cantidad) And respuestasB(cantidad) >= respuestasC(cantidad) And respuestasB(cantidad) >= respuestasD(cantidad) Then
                            respuestasGanadoras(cantidad) = "B"
                        ElseIf respuestasC(cantidad) >= respuestasA(cantidad) And respuestasC(cantidad) >= respuestasB(cantidad) And respuestasC(cantidad) >= respuestasD(cantidad) Then
                            respuestasGanadoras(cantidad) = "C"
                        Else
                            respuestasGanadoras(cantidad) = "D"
                        End If
                        If totalesRespuestas(cantidad) > 0 Then
                            If respuestasGanadoras(cantidad) = "A" Then
                                porcentajesGanadores(cantidad) = (respuestasA(cantidad) * 100) / totalesRespuestas(cantidad)
                            ElseIf respuestasGanadoras(cantidad) = "B" Then
                                porcentajesGanadores(cantidad) = (respuestasB(cantidad) * 100) / totalesRespuestas(cantidad)
                            ElseIf respuestasGanadoras(cantidad) = "C" Then
                                porcentajesGanadores(cantidad) = (respuestasC(cantidad) * 100) / totalesRespuestas(cantidad)
                            Else
                                porcentajesGanadores(cantidad) = (respuestasD(cantidad) * 100) / totalesRespuestas(cantidad)
                            End If
                        Else
                            porcentajesGanadores(cantidad) = 0
                        End If
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Encuesta registrada correctamente.")
                    End If
                '---------------------'
                '--|editar_encuesta|--'
                '---------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen encuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & respuestasA(i) & " | B: " & respuestasB(i) & " | C: " & respuestasC(i) & " | D: " & respuestasD(i) & " | Total respuestas: " & totalesRespuestas(i) & " | Respuesta ganadora: " & respuestasGanadoras(i) & " | Porcentaje ganador: " & porcentajesGanadores(i) & "% | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la encuesta a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nueva pregunta: ")
                            preguntas(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad de respuestas A: ")
                            respuestasA(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nueva cantidad de respuestas B: ")
                            respuestasB(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nueva cantidad de respuestas C: ")
                            respuestasC(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nueva cantidad de respuestas D: ")
                            respuestasD(posicion) = Convert.ToInt32(Console.ReadLine())
                            totalesRespuestas(posicion) = respuestasA(posicion) + respuestasB(posicion) + respuestasC(posicion) + respuestasD(posicion)
                            If respuestasA(posicion) >= respuestasB(posicion) And respuestasA(posicion) >= respuestasC(posicion) And respuestasA(posicion) >= respuestasD(posicion) Then
                                respuestasGanadoras(posicion) = "A"
                            ElseIf respuestasB(posicion) >= respuestasA(posicion) And respuestasB(posicion) >= respuestasC(posicion) And respuestasB(posicion) >= respuestasD(posicion) Then
                                respuestasGanadoras(posicion) = "B"
                            ElseIf respuestasC(posicion) >= respuestasA(posicion) And respuestasC(posicion) >= respuestasB(posicion) And respuestasC(posicion) >= respuestasD(posicion) Then
                                respuestasGanadoras(posicion) = "C"
                            Else
                                respuestasGanadoras(posicion) = "D"
                            End If
                            If totalesRespuestas(posicion) > 0 Then
                                If respuestasGanadoras(posicion) = "A" Then
                                    porcentajesGanadores(posicion) = (respuestasA(posicion) * 100) / totalesRespuestas(posicion)
                                ElseIf respuestasGanadoras(posicion) = "B" Then
                                    porcentajesGanadores(posicion) = (respuestasB(posicion) * 100) / totalesRespuestas(posicion)
                                ElseIf respuestasGanadoras(posicion) = "C" Then
                                    porcentajesGanadores(posicion) = (respuestasC(posicion) * 100) / totalesRespuestas(posicion)
                                Else
                                    porcentajesGanadores(posicion) = (respuestasD(posicion) * 100) / totalesRespuestas(posicion)
                                End If
                            Else
                                porcentajesGanadores(posicion) = 0
                            End If
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Encuesta actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|listar_encuestas|--'
                '----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen encuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & respuestasA(i) & " | B: " & respuestasB(i) & " | C: " & respuestasC(i) & " | D: " & respuestasD(i) & " | Total respuestas: " & totalesRespuestas(i) & " | Respuesta ganadora: " & respuestasGanadoras(i) & " | Porcentaje ganador: " & porcentajesGanadores(i) & "% | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '---------------------'
                '--|buscar_encuesta|--'
                '---------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen encuestas registradas.")
                    Else
                        Console.Write("Ingrese el ID de la encuesta a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Pregunta: " & preguntas(posicion) & " | A: " & respuestasA(posicion) & " | B: " & respuestasB(posicion) & " | C: " & respuestasC(posicion) & " | D: " & respuestasD(posicion) & " | Total respuestas: " & totalesRespuestas(posicion) & " | Respuesta ganadora: " & respuestasGanadoras(posicion) & " | Porcentaje ganador: " & porcentajesGanadores(posicion) & "% | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|eliminar_encuesta|--'
                '-----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen encuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & respuestasA(i) & " | B: " & respuestasB(i) & " | C: " & respuestasC(i) & " | D: " & respuestasD(i) & " | Total respuestas: " & totalesRespuestas(i) & " | Respuesta ganadora: " & respuestasGanadoras(i) & " | Porcentaje ganador: " & porcentajesGanadores(i) & "% | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la encuesta a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                preguntas(i) = preguntas(i + 1)
                                respuestasA(i) = respuestasA(i + 1)
                                respuestasB(i) = respuestasB(i + 1)
                                respuestasC(i) = respuestasC(i + 1)
                                respuestasD(i) = respuestasD(i + 1)
                                totalesRespuestas(i) = totalesRespuestas(i + 1)
                                respuestasGanadoras(i) = respuestasGanadoras(i + 1)
                                porcentajesGanadores(i) = porcentajesGanadores(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Encuesta eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|mostrar_analisis|--'
                '----------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen encuestas registradas.")
                    Else
                        Dim activas As Integer = 0
                        Dim finalizadas As Integer = 0
                        Dim enProceso As Integer = 0
                        Dim canceladas As Integer = 0
                        Dim totalParticipantes As Integer = 0
                        Dim totalA As Integer = 0
                        Dim totalB As Integer = 0
                        Dim totalC As Integer = 0
                        Dim totalD As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            totalParticipantes += totalesRespuestas(i)
                            totalA += respuestasA(i)
                            totalB += respuestasB(i)
                            totalC += respuestasC(i)
                            totalD += respuestasD(i)
                            If estados(i).ToLower() = "activa" Then
                                activas += 1
                            ElseIf estados(i).ToLower() = "finalizada" Then
                                finalizadas += 1
                            ElseIf estados(i).ToLower() = "en proceso" Then
                                enProceso += 1
                            ElseIf estados(i).ToLower() = "cancelada" Then
                                canceladas += 1
                            End If
                        Next
                        Dim respuestaMasSeleccionada As String
                        Dim mayorCantidad As Integer
                        mayorCantidad = totalA
                        respuestaMasSeleccionada = "A"
                        If totalB > mayorCantidad Then
                            mayorCantidad = totalB
                            respuestaMasSeleccionada = "B"
                        End If
                        If totalC > mayorCantidad Then
                            mayorCantidad = totalC
                            respuestaMasSeleccionada = "C"
                        End If
                        If totalD > mayorCantidad Then
                            mayorCantidad = totalD
                            respuestaMasSeleccionada = "D"
                        End If
                        Console.WriteLine("Encuestas: " & cantidad & " | Activas: " & activas & " | Finalizadas: " & finalizadas & " | En proceso: " & enProceso & " | Canceladas: " & canceladas & " | Participantes: " & totalParticipantes & " | A: " & totalA & " | B: " & totalB & " | C: " & totalC & " | D: " & totalD & " | Respuesta mas seleccionada: " & respuestaMasSeleccionada)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Analisis de Encuestas.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7

    End Sub
End Module