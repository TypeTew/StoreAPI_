INSERT INTO categories (
    category_name,
    category_status
)

VALUES
(
    'Mobile',
    1
),
(
    'Tablet',
    1
),
(
    'Smart Watch',
    1
),
(
    'Labtop',
    1
);

products
---
INSERT INTO products (
    category_id,
    product_name,
    unit_price,
    product_picture,
    unit_in_stock,
    created_date,
    modified_date
)

VALUES
(
    1,
    'iPhone 13 Pro Max',
    55000,
    'https://www.mxphone.com/wp-content/uploads/2021/04/41117-79579-210401-iPhone12ProMax-xl-1200x675.jpg',
    3,
    '2021-11-22T00:00:00',
    '2021-11-22T00:00:00'
),
(
    2,
    'iPad Pro 2021',
    18500,
    'https://cdn.siamphone.com/spec/apple/images/ipad_pro_12.9%E2%80%91inch/com_1.jpg',
    10,
    '2021-11-20T00:00:00',
    '2021-11-20T00:00:00'
),
(
    3,
    'Airpods Pro',
    12500,
    'https://support.apple.com/library/content/dam/edam/applecare/images/en_US/airpods/airpods-pro-2gen-front-case.png',
    5,
    '2021-11-10T10:30:00',
    '2021-11-12T10:30:00'
),
(
    4,
    'Macbook Pro M1',
    45000,
    'https://cdn.mos.cms.futurecdn.net/iYCQTPgBSdDmkYESfPkunh.jpg',
    10,
    '2021-11-15T10:30:00',
    '2021-11-15T10:30:00'
);
