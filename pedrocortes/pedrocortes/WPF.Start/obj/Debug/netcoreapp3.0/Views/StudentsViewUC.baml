   M S B A M L   `   `   `  ����D  @WPF.Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF.Start.ViewsWPF.Start.Views  5      $    WPF.Start.Views.StudentsViewUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      )localclr-namespace:WPF.Start.Views  5      .��5      � ���	#FFE5E5E5  � ColumnDefinitions  5   
   �� 5      $	��400 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $��* �6    �� 5      $	��200 �6    .+�5      � $��0��6   .+�5      �� $��Center=�6   $3��-WELCOME TO THE CLASS! LET'S HANDLE STUDENTS!!��69   $
��Wrap=�6n   $��Center=�6�   $	��380��6�   $��16(�6�   �� 5      $��Center=�6   $#��What do you want to do today?��69   $
��Wrap=�6^   $	��Top=�6r   $	��204��6�   $��14(�6�   $��0,61,0,0q�6�   5      � 5      $��1��6   $��0,10,0,0q�6    .+�5!      �� $
��Left=�6   $��26��65   $��	98,17,0,0q�6A    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $	��268��6�   ��6T   �� *Name+ �� Mode$ TwoWay=�6�   �� 5"      $
��Left=�6   $��26��65   $��	98,59,0,0q�6A   $
 Wrap=�6v   $	��Top=�6�   $	��268��6�   ��6T   �� *Dni+$ TwoWay=�6�   �� 5#      $
��Left=�6   $��26��65   $��
98,104,0,0q�6A   $
 Wrap=�6y   $	��Top=�6�   $	��268��6�   ��6U   �� *Chair+$ TwoWay=�6�   �� 5$      $
��Left=�6   $��	22,22,0,0q�67   $��Nombre:��6J   $
��Wrap=�6Y   $	��Top=�6m   $��60��6�   $��26��6�    �� TextAlignment$ Right=�6�   $��14(�6�   �� 5%      $
��Left=�6   $��	22,64,0,0q�67   $
��Dni:��6J   $
��Wrap=�6V   $	��Top=�6j   $��60��6�   $��26��6�   $ Right=�6�   $��14(�6�   �� 5&      $
��Left=�6   $��
22,109,0,0q�67   $��Chair:��6K   $
��Wrap=�6Y   $	��Top=�6m   $��60��6�   $��26��6�   $ Right=�6�   $��14(�6�   �� 5(      $��Register��69   $
��Left=�6L   $��
98,151,0,0q�6g   $	��Top=�6{   ���	#FFE800FF$��32��6�   $	��134��6�   ��6   �� *SaveCommand+6�   �� 5)      $��Clear��6:   $
��Left=�6J   $��232,151,0,0q�6e   $	��Top=�6z   ���	#FFE800FF$��32��6�   $	��131��6�   ��6   �� *ClearCommand+6�   5+      � 5-      $��2��6    5/      �� 50      $��20 �6$   �� 51      $��* �6$   �� 52      $��17 �6$   �� 53      $��70 �6$   .+�56      � $��0��6   .+�57      �� $
��Left=�6    $��Message to the user��6;   $
��Wrap=�6V   $��Center=�6j   $��42,0,0,0q�6�   58      � 5:      $��1��6   .+�5;      �� $��	40,5,37,5q�6>   ���	#FFF0F0F0
���  ����6   �� *MessageToUser+6h   5<      � 5>      $��2��6   .+�5?      �� $
��Left=�6    $��Info to the user��6;   $
��Wrap=�6S   $��Center=�6g   $��41,0,0,0q�6�   $��91��6�   5@      � 5B      $��3��6     5C      �� 5D      $	��77* �6+   �� 5E      $
��323* �6+   .+�5G      �� $
��Left=�6    $9��3The number of students signed up at this moment is:��6;   $
��Wrap=�6v   $	��Top=�6�   $��10(�6�   $��	40,-3,0,0q�6�   $��2��6�   �� 5H      $��201,-11,100,53q�6?   $��1��6W   $��10(�6g   ��6   �� *Students.Count+6g   �� 5I      $
��Left=�6    $����CopyLeft!! Todos los contenidos de este programa (Incluyendo, pero no limitado a, texto, logotipos, contenido, fotografías, audio, botones, nombres comerciales y vídeo) están sujetos a derechos de libertad de uso y distribución. No se preocupe!��6;   $
��Wrap=�67  $��Center=�6K  $��8(�6f  $	��320��6s  $��2��6  $��40,0,0,0q�6�  �� 5J      $��261,-11,40,53q�6:   $��1��6Q   $��10(�6a   ��6   �� *	StdInDict+6a   5K      5N      5R      � 5T   
   $��1��6   .+�5V      &   System.Windows.Controls.DataGrid  $��5q�6`      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6k      AutoGenerateColumns$ False��6}   ��6   �� *
Students+ �� SelectedItem 68   �� *CurrentStudent+.  (System.Windows.Interactivity.Interaction   Triggers 5X      /  )System.Windows.Interactivity.EventTrigger  5Y      	   	EventName$	 Loaded��6%   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5Z      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *GetInfoCommand+5[         Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$	 Dni��6)      Width$ * 6N   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 66   �� *Dni+6N     5`      $
 Name��6)   $ * 6P    67   �� *Name+6P     5a      $ Chair��6)   $ * 6R    68   �� *Chair+6R     5b      $ Id��6)   $	 300 6L    65   �� *Id+6L   4
  .System.Windows.Controls.DataGridTemplateColumn
  5c      $ 70 6.    
  CellTemplate 5d      �� 5e      .R�5f   "   �� $
��Edit��6)   ��68   �� *DataContext.EditCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType"  5g      5i      
  5j      $ 70 6-    5k      �� 5l      .R�5m   "   �� $��Delete��6)   ��6:   �� *DataContext.DeleteCommand+ �� $ FindAncestor=�"  5n      5p      5s      5u      5w      5x      