Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Imaging.Filters
Imports AForge.Imaging

Public Class Form1

    Dim FUENTES As FilterInfoCollection 'TODAS LAS CAMARAS
    Dim FUENTE As VideoCaptureDevice 'LA CAMARA

    'INICIALIZACION VALORES FILTRO
    Dim MINR As Integer = 0
    Dim MING As Integer = 0
    Dim MINB As Integer = 0
    Dim MAXR As Integer = 255
    Dim MAXG As Integer = 255
    Dim MAXB As Integer = 255

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBOBOX
        FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If FUENTES.Count > 0 Then
            For Each ITEM In FUENTES
                ComboBox1.Items.Add(ITEM.Name.ToString())
            Next

            CheckForIllegalCrossThreadCalls = False 'PERMITE QUE SE ESCRIBA EN LAS ETIQUETAS DURANTE EL THREAD Video_NewFrame

            Me.Location = New System.Drawing.Point(Me.Location.X, 0) 'SITUA EL FORMULARIO EN LA PARTE SUPERIOR DE LA PANTALLA
        Else
            MsgBox("NO HAY CAMARAS DISPONIBLES")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'INICIA LA CAPTURA DE IMAGENES DE LA CAMARA Y EL THREAD Video_NewFrame
        FUENTE = New VideoCaptureDevice(FUENTES(ComboBox1.SelectedIndex).MonikerString)
        AddHandler FUENTE.NewFrame, New NewFrameEventHandler(AddressOf Video_NewFrame)
        FUENTE.Start()
        ComboBox1.Visible = False
    End Sub
   
    Private Sub Video_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)

        Dim ORIGINAL As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'IMAGEN DE LA CAMARA
        Dim FILTRADO As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'IMAGEN FILTRADA

        'FILTRADO DE COLOR
        Dim FILTRO As New ColorFiltering
        FILTRO.Red = New IntRange(MINR, MAXR)
        FILTRO.Green = New IntRange(MING, MAXG)
        FILTRO.Blue = New IntRange(MINB, MAXB)
        FILTRO.ApplyInPlace(FILTRADO)

        'PONE FILTRADO EN ESCALA DE GRISES PARA PODER PROCESAR BLOBS
        Dim GRIS As Grayscale = Grayscale.CommonAlgorithms.BT709
        Dim IMAGENG As Bitmap = GRIS.Apply(FILTRADO)

        'CLASIFICA FILTRADO (GRIS) EN ZONAS (BLOB)
        Dim BLOBS As New BlobCounter()
        BLOBS.MinHeight = 10 'SOLO TOMARA LAS QUE TENGAN UN TAMAÑO DETERMINADO
        BLOBS.MinWidth = 10 'SOLO TOMARA LAS QUE TENGAN UN TAMAÑO DETERMINADO
        BLOBS.ObjectsOrder = ObjectsOrder.Size 'TOMARA LA MAYOR
        BLOBS.ProcessImage(IMAGENG) 'EJECUTA EL CLASIFICADOR

        Dim RECTANGULOS As Rectangle() = BLOBS.GetObjectsRectangles() 'COLECCION DE BLOBS PASADOS A RECTANGULOS
        If RECTANGULOS.Count > 0 Then ' SI HAY MAS DE UNO......
            Dim RECTANGULO As Rectangle = RECTANGULOS(0) '...TOMA EL PRIMERO PORQUE ES EL MAS GRANDE
            Dim DIBUJO As Graphics = Graphics.FromImage(ORIGINAL) '.... Y SOBRE LA IMAGEN DEL PICTUREBOX....
            Dim TRAZO As New Pen(Color.Lime, 5)
            DIBUJO.DrawRectangle(TRAZO, RECTANGULO) 'DIBUJA EL RECTANGULO DEL BLOB
            DIBUJO.Dispose() 'LIBERA EL DIBUJO ANTERIOR
        End If

        PictureBoxORIGINAL.Image = ORIGINAL 'PRESENTA LAS IMAGENES
        PictureBoxFILTRADO.Image = FILTRADO 'PRESENTA LAS IMAGENES
    End Sub

    'CAMBIOS EN LOS VALORES DE LOS TRACKBARS
    Private Sub TrackBarMINR_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMINR.Scroll
        MINR = TrackBarMINR.Value
        LabelMINR.Text = "MINR: " & MINR
    End Sub

    Private Sub TrackBarMING_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMING.Scroll
        MING = TrackBarMING.Value
        LabelMING.Text = "MING: " & MING
    End Sub

    Private Sub TrackBarMINB_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMINB.Scroll
        MINB = TrackBarMINB.Value
        LabelMINB.Text = "MINB: " & MINB
    End Sub

    Private Sub TrackBarMAXR_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMAXR.Scroll
        MAXR = TrackBarMAXR.Value
        LabelMAXR.Text = "MAXR: " & MAXR
    End Sub

    Private Sub TrackBarMAXG_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMAXG.Scroll
        MAXG = TrackBarMAXG.Value
        LabelMAXG.Text = "MAXG: " & MAXG
    End Sub

    Private Sub TrackBarMAXB_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBarMAXB.Scroll
        MAXB = TrackBarMAXB.Value
        LabelMAXB.Text = "MAXB: " & MAXB
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            FUENTE.SignalToStop() 'CIERRA EL THREAD Video_NewFrame
        Catch ex As Exception
        End Try
    End Sub
End Class
