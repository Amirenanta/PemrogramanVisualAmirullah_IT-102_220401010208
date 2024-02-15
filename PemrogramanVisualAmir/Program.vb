Imports System.IO

Module Module1

    Sub Main()
        ' Meminta input dari pengguna
        Console.WriteLine("Program Kalkulator Sederhana")
        Console.WriteLine("Ketik 'file' untuk menampilkan isi file.")
        Console.WriteLine("Ketik 'kalkulator' untuk menggunakan kalkulator.")
        Console.Write("Masukkan pilihan Anda: ")
        Dim input As String = Console.ReadLine()

        ' Memeriksa input pengguna
        If input.ToLower() = "file" Then
            Dim filePath As String = "C:\Users\Zhii\Documents\Tsest.txt"
            ReadFile(filePath)
        ElseIf input.ToLower() = "kalkulator" Then
            RunCalculator()
        Else
            Console.WriteLine("Pilihan tidak valid.")
        End If
    End Sub

    Sub ReadFile(ByVal filePath As String)
        Try
            Using reader As New StreamReader(filePath)
                Dim line As String
                Do While (reader.Peek() >= 0)
                    line = reader.ReadLine()
                    Console.WriteLine(line)
                Loop
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub RunCalculator()
        Dim choice As Integer
        Do
            ' Menampilkan menu
            Console.WriteLine("=== Program Kalkulator Sederhana ===")
            Console.WriteLine("Pilih operasi yang ingin Anda lakukan:")
            Console.WriteLine("1. Penjumlahan")
            Console.WriteLine("2. Pengurangan")
            Console.WriteLine("3. Perkalian")
            Console.WriteLine("4. Pembagian")
            Console.WriteLine("5. Keluar")
            Console.Write("Masukkan pilihan Anda (1-5): ")

            ' Membaca pilihan pengguna
            choice = Integer.Parse(Console.ReadLine())

            ' Memanggil procedure berdasarkan pilihan pengguna
            Select Case choice
                Case 1
                    AddOperation()
                Case 2
                    SubtractOperation()
                Case 3
                    MultiplyOperation()
                Case 4
                    DivideOperation()
                Case 5
                    Console.WriteLine("Terima kasih telah menggunakan program.")
                Case Else
                    Console.WriteLine("Pilihan tidak valid. Silakan masukkan pilihan yang benar.")
            End Select

            Console.WriteLine()
        Loop While choice <> 5
    End Sub

    Sub AddOperation()
        ' Meminta input dari pengguna
        Console.Write("Masukkan angka pertama: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())

        ' Melakukan penjumlahan
        Dim result As Double = num1 + num2

        ' Menampilkan hasil
        Console.WriteLine("Hasil penjumlahan: " & result)
    End Sub

    Sub SubtractOperation()
        ' Meminta input dari pengguna
        Console.Write("Masukkan angka pertama: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())

        ' Melakukan pengurangan
        Dim result As Double = num1 - num2

        ' Menampilkan hasil
        Console.WriteLine("Hasil pengurangan: " & result)
    End Sub

    Sub MultiplyOperation()
        ' Meminta input dari pengguna
        Console.Write("Masukkan angka pertama: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())

        ' Melakukan perkalian
        Dim result As Double = num1 * num2

        ' Menampilkan hasil
        Console.WriteLine("Hasil perkalian: " & result)
    End Sub

    Sub DivideOperation()
        ' Meminta input dari pengguna
        Console.Write("Masukkan angka pertama: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())

        ' Memastikan angka kedua bukan nol untuk menghindari pembagian dengan nol
        If num2 <> 0 Then
            ' Melakukan pembagian
            Dim result As Double = num1 / num2
            ' Menampilkan hasil
            Console.WriteLine("Hasil pembagian: " & result)
        Else
            Console.WriteLine("Error: Tidak bisa melakukan pembagian dengan nol.")
        End If
    End Sub

End Module
