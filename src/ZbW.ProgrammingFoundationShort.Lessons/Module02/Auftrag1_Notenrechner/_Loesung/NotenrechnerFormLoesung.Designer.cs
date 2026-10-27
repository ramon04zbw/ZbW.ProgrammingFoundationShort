namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

partial class NotenrechnerFormLoesung
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblPunkte = new Label();
    TxtPunkte = new TextBox();
    CmdBerechnen = new Button();
    LblNote = new Label();
    LblBewertung = new Label();
    SuspendLayout();
    // 
    // LblPunkte
    // 
    LblPunkte.AutoSize = true;
    LblPunkte.Location = new Point(17, 33);
    LblPunkte.Margin = new Padding(4, 0, 4, 0);
    LblPunkte.Name = "LblPunkte";
    LblPunkte.Size = new Size(134, 25);
    LblPunkte.TabIndex = 0;
    LblPunkte.Text = "Punkte (0–100):";
    // 
    // TxtPunkte
    // 
    TxtPunkte.Location = new Point(200, 28);
    TxtPunkte.Margin = new Padding(4, 5, 4, 5);
    TxtPunkte.Name = "TxtPunkte";
    TxtPunkte.Size = new Size(113, 31);
    TxtPunkte.TabIndex = 1;
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(200, 83);
    CmdBerechnen.Margin = new Padding(4, 5, 4, 5);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(186, 47);
    CmdBerechnen.TabIndex = 2;
    CmdBerechnen.Text = "Note berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblNote
    // 
    LblNote.AutoSize = true;
    LblNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    LblNote.Location = new Point(17, 150);
    LblNote.Margin = new Padding(4, 0, 4, 0);
    LblNote.Name = "LblNote";
    LblNote.Size = new Size(0, 32);
    LblNote.TabIndex = 3;
    // 
    // LblBewertung
    // 
    LblBewertung.AutoSize = true;
    LblBewertung.Location = new Point(17, 197);
    LblBewertung.Margin = new Padding(4, 0, 4, 0);
    LblBewertung.Name = "LblBewertung";
    LblBewertung.Size = new Size(0, 25);
    LblBewertung.TabIndex = 4;
    // 
    // NotenrechnerFormLoesung
    // 
    AutoScaleDimensions = new SizeF(10F, 25F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(457, 250);
    Controls.Add(LblPunkte);
    Controls.Add(TxtPunkte);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblNote);
    Controls.Add(LblBewertung);
    Margin = new Padding(4, 5, 4, 5);
    Name = "NotenrechnerFormLoesung";
    Text = "Notenrechner – Lösung";
    Load += NotenrechnerFormLoesung_Load;
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPunkte;
  private TextBox TxtPunkte;
  private Button CmdBerechnen;
  private Label LblNote;
  private Label LblBewertung;
}
