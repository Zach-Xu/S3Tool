   M S B A M L   `   `   `  ����N  JZhenXu_COMP306_Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ZhenXu_COMP306_Lab1.ViewsZhenXu_COMP306_Lab1.Views  5   	   ,    &ZhenXu_COMP306_Lab1.Views.UploadObject   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ZhenXu_COMP306_Lab1.Views     5   	   -   5          � Title$'  !Upload Object to S3 Bucket Window��5	   	   $	��450��5
   	   $	��800��5   	   .��5      � .+�5   
   �� $��Bucket��6   $
��Left=�5      $��	70,32,0,0q�5      $��18(�5      $	��Top=�5      �� 5   
   $��Object��6   $
��Left=�5      $��	70,84,0,0q�5      $	��Top=�5      $��35��5      $��18(�5      $��73��5       J� RenderTransformOrigin$ 0.338,0.774&�5      �� 5   
   -   5         ��Name$ 	cbBuckets��5      $
��Left=�5      $��
170,31,0,0q�5       �� DisplayMemberPath$ 
BucketName��5      $	��Top=�5      $	��365��5      $��18(�5!      $��35��5"      �� 5#   
   -   5         ��Name$ 	txtObject��5#      $
��Left=�5$      $��
170,84,0,0q�5%       �� TextWrapping$
 Wrap=�5&      $��18(�5'      $	��Top=�5(      $	��365��5)      $��35��5*      &   System.Windows.Controls.DataGrid  5+   
   -   5          Name$ objectDataGrid��5+         AutoGenerateColumns$ False��5,         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5-      $��35,141,245,33q�5/      	   Columns	 50      0  *System.Windows.Controls.DataGridTextColumn  51      -   5        objectColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Object Name��53   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 52   %   ��  �� Path$	 Key� �� Mode$ OneWay=�53   %     54      -   5        
dateColumn��$

 Size��56   %      SortDirection 	Ascending57   %    55   %   �� $
 Size�$ OneWay=�57   %   59      �� 5:   
   -   5        $��Browse��5:      $
��Left=�5;      $��
580,56,0,0q�5<      $��18(�5=      $	��Top=�5>      $��60��5?      $	��196��5@      5A      �� 5B   
   -   5        $��Upload��5B      $
��Left=�5C      $��580,159,0,0q�5D      $��18(�5E      $	��Top=�5F      $��60��5G      $	��196��5I      �� 5J   
   -	   5        $��Back to Main Window��5J      $
��Left=�5K      $��580,304,0,0q�5L      $��18(�5M      $	��Top=�5N      $��60��5O      $	��196��5P      5Q      5S      5T      