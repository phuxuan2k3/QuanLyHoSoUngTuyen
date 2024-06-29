namespace GUI.CC;

public class Layout
{
	public static void Set(TableLayoutPanel tableLayoutPanel)
	{
		tableLayoutPanel.ColumnCount = 1;
		tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
		tableLayoutPanel.RowCount = 2;
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
		tableLayoutPanel.Dock = DockStyle.Fill;

		var label = new Label
		{
			Anchor = AnchorStyles.None,
			Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
			Name = "_title",
		};
		tableLayoutPanel.Controls.Add(label, 0, 0);
	}
}
