# Visual Assets Generation Report

## 繁體中文

- 圖像生成模型標準：`x/z-image-turbo`。目前 font/background/VFX assets 由 local deterministic renderer 落地，必須在 manifest/report 中保留此模型設定作為圖像生成 contract 與 provenance。
- 已由 local script 產生 bitmap font atlas、typography manifest、neon track background、VFX spritesheet 與 Unity 對應資產。
- 背景與特效遵守 spec review：深色賽道、霓虹邊線、低密度粒子、保守 Bloom/screen shake，並保留 reduced-motion 規則。
- Style frame implementation 已建立：main menu、gameplay、reward/boost、danger/near miss、failure/game-over、retry result 都必須能映射到 Unity screen state 與 QA screenshot/video evidence。
- 驗證條件：所有 PNG 必須可讀且符合指定尺寸；font/background/VFX manifest 不可缺失。

## English

- Image generation model standard: `x/z-image-turbo`. Current font/background/VFX assets are materialized by a local deterministic renderer, and this model setting must remain in manifests/reports as the image generation contract and provenance.
- The local script generated the bitmap font atlas, typography manifest, neon track background, VFX spritesheet, and Unity-facing assets.
- Background and effects follow spec review: dark track, neon lane edges, low-density particles, conservative Bloom/screen shake, and reduced-motion rules.
- Style frame implementation is established: main menu, gameplay, reward/boost, danger/near miss, failure/game-over, and retry result must map to Unity screen states and QA screenshot/video evidence.
- Validation: every PNG must be readable and match the required size; font/background/VFX manifests must not be missing.
