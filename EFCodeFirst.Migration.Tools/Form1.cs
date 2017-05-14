using EFCodeFirst.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Windows.Forms;

namespace EFCodeFirst.Migration.Tools
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using (var db = new EFCodeFirstContext())
			{
				bool ischeck = true;

				do
				{
					if (db.Database.Exists())
					{
						bool dbState = db.Database.CompatibleWithModel(true);
						btnUpdate.Enabled = !dbState;
						btnScript.Enabled = !dbState;
						lblMessage.Text = dbState ? "Veritabanı güncel." : "Veritabanında değişiklikler var.";
						ischeck = false;
					}
					else
					{
						lblMessage.Text = "Veritabanı yok. Oluşturulmalı.";

						DialogResult dialogResult = MessageBox.Show("Veri tabanı yok; Oluşturulsun mu?", "Veritabanı Yok!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if (dialogResult == DialogResult.Yes)
						{
							var initializer = new MigrateDatabaseToLatestVersion<EFCodeFirstContext, EFCodeFirst.Data.Migrations.Configuration>();
							initializer.InitializeDatabase(db);
							lblMessage.Text = "Veritabanı oluşturuldu.";
							ischeck = true;
						}
						else if (dialogResult == DialogResult.No)
						{
							ischeck = false;
							Application.Exit();
							
						}
					}
				} while (ischeck);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			using (var db = new EFCodeFirstContext())
			{
				if (!db.Database.CompatibleWithModel(true))
				{
					var initializer = new MigrateDatabaseToLatestVersion<EFCodeFirstContext, EFCodeFirst.Data.Migrations.Configuration>();
					initializer.InitializeDatabase(db);
					lblMessage.Text = "Veritabanı güncellendi.";
					btnUpdate.Enabled = false;
					btnScript.Enabled = false;
				}
			}
		}

		private void btnScript_Click(object sender, EventArgs e)
		{
			using (var db = new EFCodeFirstContext())
			{
				if (!db.Database.CompatibleWithModel(true))
				{
					var migrator = new DbMigrator(new EFCodeFirst.Data.Migrations.Configuration());
					var script = new MigratorScriptingDecorator(migrator);
					rtbScript.Text = script.ScriptUpdate(sourceMigration: null, targetMigration: null);
				}
			}
		}
	}
}
