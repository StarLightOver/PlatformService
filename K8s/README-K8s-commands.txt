- Запускает Кибернетс, запускает указанное количество Подов с приложением. -f - указывает на файл конфигурации
kubectl apply -f platforms-depl.yaml

- Получить количество приложений
kubectl get deployments

- Получить количество Подов (хз в чем разница между Деплоем и Подом, но деплоя может быть много Подов, а каждый Под относится к одной группе деплоя) 
kubectl get pods

- Уничтожить деплой
kubectl delete deployment platforms-depl

=========================
platforms-depl.yaml - Конфиг для развертки основного приложения
platforms-np-srv.yaml - Конфиг для развертки NodePort-а, который сможет получать доступ к приложению во время разработки
=========================