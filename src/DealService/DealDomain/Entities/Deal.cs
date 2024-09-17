﻿using DealDomain.Enums;

namespace DealDomain.Entities;

/// <summary>
/// Сделка
/// </summary>
public class Deal
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// Статус
    /// </summary>
    public DealStatus Status { get; set; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// Провайдер
    /// </summary>
    public string? Provider { get; set; }

    /// <summary>
    /// Тариф
    /// </summary>
    public string? Tariff { get; set; }

    /// <summary>
    /// Дополнительная информация
    /// </summary>
    public string? AdditionalInformation { get; set; }

    /// <summary>
    /// Количество услуг
    /// </summary>
    public int? NumberOfServices { get; set; }

    /// <summary>
    /// Идентификатор риелтора
    /// </summary>
    public Guid? RealtorId { get; set; }

    /// <summary>
    /// Риелтор
    /// </summary>
    public Realtor? Realtor { get; set; }

    /// <summary>
    /// Идентификатор источника
    /// </summary>
    public Guid SourceId { get; set; }

    /// <summary>
    /// Источник
    /// </summary>
    public Source Source { get; set; } = default!;

    /// <summary>
    /// Оплата
    /// </summary>
    public decimal Payment { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который отвветственный за данную сделку
    /// </summary>
    public Guid ResponsibleUserId { get; set; }
}
