   M S B A M L   `   `   `  ����N  JZhenXu_COMP306_Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ZhenXu_COMP306_Lab1.ViewsZhenXu_COMP306_Lab1.Views  5   	   ,    &ZhenXu_COMP306_Lab1.Views.CreateBucket   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ZhenXu_COMP306_Lab1.Views     5   	   -   5          � Title$  Create Bucket��5	   	   $	��435��5
   	   $	��800��5   	   .��5      � $��0,0,0,0q�6   .+�5   
   �� $��Bucket Name��6   $
��Left=�5      $��	49,26,0,0q�5      $��18(�5      $	��Top=�5      �� 5   
   -   5         ��Name$ txtBucketName��5      $
��Left=�5      $��
178,28,0,0q�5       �� TextAlignment$ Justify=�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5      $	��380��5      $��20(�5      $��36��5       J� RenderTransformOrigin$ -0.22,0.623&�5      �� 5   
   -   5        $��Create Bucket��5      $
��Left=�5      $��
615,29,0,0q�5      $��18(�5       $	��Top=�5!      $ 0.484,0.073&�5"      $��34��5#      $	��130��5$      5%      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ bucketDataGrid��5&         AutoGenerateColumns$ False��5'         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5(      $��20,114,25,121q�5*         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      -   5        bucketColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Bucket Name��5.   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5-   %   ��  �� Path$ 
BucketName� �� Mode$ OneWay=�5.   %     5/      -   5        
dateColumn��$	 Creation Date��51   %      SortDirection 	Ascending52   %   
 50   %   �� $ CreationDate�$ OneWay=�52   %   54      �� 55   
   -   5        $��Back to Main Window��55      $
��Left=�56      $��270,344,0,0q�57      $	��Top=�58      $ 0.883,-1.251&�59      $	��254��5:      $��18(�5;      $��40��5<      5=      �� 5>   
   -   5         ��Name$ 
lblWarning��5?      $H��BBucket Name must not contain uppercase characters and white spaces��5@      $
��Left=�5A      $��
178,79,0,0q�5B      $	��Top=�5C      $��30��5D      $	��402��5E      $y�Hidden=�5F      5H      5I      