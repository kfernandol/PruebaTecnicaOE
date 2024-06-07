SELECT m.Mensaje, p.Nombre AS Proyecto,
       CASE
           WHEN NOT EXISTS (
               SELECT 1
               FROM Producto pr
               WHERE pr.Proyecto = p.Proyecto
                 AND NOT EXISTS (
                     SELECT 1
                     FROM Mensaje m2
                     WHERE m2.Mensaje = m.Mensaje
                       AND m2.Producto = pr.Producto
                 )
           ) THEN 'TODOS'
           ELSE (
               SELECT STRING_AGG(pr2.Descripcion, ', ')
               FROM Producto pr2
               WHERE pr2.Producto = m.Producto
                 AND pr2.Proyecto = p.Proyecto
           )
       END AS Producto
FROM Mensaje m
JOIN Proyecto p ON m.Proyecto = p.Proyecto
GROUP BY m.Mensaje, p.Nombre;
