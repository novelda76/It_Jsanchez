   M S B A M L   `   `   `  ����O  KAcademyFinal.App.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AcademyFinal.App.WPF.ViewsAcademyFinal.App.WPF.Views  5      -    'AcademyFinal.App.WPF.Views.StudentsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:AcademyFinal.App.WPF.Views     5      .��5      � ���	#FFE5E5E5  � RowDefinitions  5   
   �� 5      $	��150 �6   6+   �� 5      $��* �6   6)   .+�5   
   � $��0��6   .+�5      �� $
��Left=�6   $��Nombre Estudiante:��6/   $��20,6,0,0q�6L   $	��Top=�6^   �� 5      $
��Left=�6   $��
155,10,0,0q�61    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   ��6E   �� *Name+6�   �� 5      $
��Left=�6   $��DNI Estudiante:��6/   $��	20,39,0,0q�6I   $	��Top=�6\   �� 5      $
��Left=�6   $��
155,45,0,0q�61   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   ��6E   �� *Dni+6�   �� 5      $
��Left=�6   $��Número silla asignada:��6/   $��	20,75,0,0q�6P   $	��Top=�6c   �� 5      $
��Left=�6   $��
155,80,0,0q�61   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   ��6E   �� *ChairNumber+6�   �� 5      $	��100��6   $��30��6!   $��Guardar Estudiante��6-   ��6J   �� *AddStudentCommand+5      � 5    
   $��1��6     5!      �� 5"      $��* �6    6-   �� 5#      $��40 �6    6.   .+�5&      � $��0��6   .+�5'      &   System.Windows.Controls.DataGrid  $��5q�6<   ��6   �� *
Students+6<   5(      � 5)      $��1��6   .+�5*      �� $��Get Students��6   $	��100��6W   $��5q�6c   $��Right=�6n   ��60   �� *GetStudentsCommand+6n   5+      5,      5/      50      